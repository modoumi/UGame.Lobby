/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-02-20 19: 23:44
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
	/// 【表 sr_user_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_user_dayEO : IRowMapper<Sr_user_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_user_dayEO()
		{
			this.UserKind = 0;
			this.FromMode = 0;
			this.IsNew = false;
			this.IsLogin = false;
			this.LoginDays = 0;
			this.IsRegister = false;
			this.IsNewBet = false;
			this.HasBet = false;
			this.IsNewPay = false;
			this.HasPay = false;
			this.IsNewCash = false;
			this.HasCash = false;
			this.BetCount = 0;
			this.BetAmount = 0;
			this.BetBonus = 0;
			this.WinCount = 0;
			this.WinAmount = 0;
			this.WinBonus = 0;
			this.PayCount = 0;
			this.PayAmount = 0;
			this.CashCount = 0;
			this.CashAmount = 0;
			this.ActivityCount = 0;
			this.ActivityAmount = 0;
			this.ChangeCount = 0;
			this.ChangeAmount = 0;
			this.CashAuditAmount = 0;
			this.PayUserFee = 0.000m;
			this.PayOwnFee = 0.000m;
			this.CashUserFee = 0.000m;
			this.CashOwnFee = 0.000m;
			this.EndBalance = 0;
			this.EndBonus = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayID;
		/// <summary>
		/// 【数据库中的原始主键 DayID 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayID
		{
			get { return _originalDayID; }
			set { HasOriginal = true; _originalDayID = value; }
		}
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 统计日
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int UserKind { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int FromMode { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///              FromMode=
		///              0-运营商的新用户(s_operator)==> OperatorID
		///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 8)]
		public string FromId { get; set; }
		/// <summary>
		/// 是否新用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool IsNew { get; set; }
		/// <summary>
		/// 当天是否登录
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 10)]
		public bool IsLogin { get; set; }
		/// <summary>
		/// 连续登录天数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int LoginDays { get; set; }
		/// <summary>
		/// 上次登录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime? LastLoginTime { get; set; }
		/// <summary>
		/// 当天是否进行了注册
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 13)]
		public bool IsRegister { get; set; }
		/// <summary>
		/// 注册时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime? RegistDate { get; set; }
		/// <summary>
		/// 是否是第一次下注用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 15)]
		public bool IsNewBet { get; set; }
		/// <summary>
		/// 当天是否下注
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 16)]
		public bool HasBet { get; set; }
		/// <summary>
		/// 是否是第一次充值用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 17)]
		public bool IsNewPay { get; set; }
		/// <summary>
		/// 当天是否充值
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 18)]
		public bool HasPay { get; set; }
		/// <summary>
		/// 是否第一次体现用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 19)]
		public bool IsNewCash { get; set; }
		/// <summary>
		/// 当天是否有提现行为
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 20)]
		public bool HasCash { get; set; }
		/// <summary>
		/// 下注次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 21)]
		public int BetCount { get; set; }
		/// <summary>
		/// 当天用户下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 当天用户bonus下注
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 返奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 24)]
		public int WinCount { get; set; }
		/// <summary>
		/// 当天用户返奖额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 25)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 当天用户bonus返奖
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 26)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 充值次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 27)]
		public int PayCount { get; set; }
		/// <summary>
		/// 当天用户充值额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 28)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 提现次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 29)]
		public int CashCount { get; set; }
		/// <summary>
		/// 当天用户提现额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 30)]
		public long CashAmount { get; set; }
		/// <summary>
		/// 活动赠送bonus次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 31)]
		public int ActivityCount { get; set; }
		/// <summary>
		/// 活动赠送bonus总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 32)]
		public long ActivityAmount { get; set; }
		/// <summary>
		/// 变化次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 33)]
		public int ChangeCount { get; set; }
		/// <summary>
		/// 变化总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 34)]
		public long ChangeAmount { get; set; }
		/// <summary>
		/// 提现待审金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 35)]
		public long CashAuditAmount { get; set; }
		/// <summary>
		/// 当天用户充值手续费
		/// 【字段 decimal(20,3)】
		/// </summary>
		[DataMember(Order = 36)]
		public decimal PayUserFee { get; set; }
		/// <summary>
		/// 当天用户充值我方手续费
		/// 【字段 decimal(20,3)】
		/// </summary>
		[DataMember(Order = 37)]
		public decimal PayOwnFee { get; set; }
		/// <summary>
		/// 当天用户提现手续费
		/// 【字段 decimal(20,3)】
		/// </summary>
		[DataMember(Order = 38)]
		public decimal CashUserFee { get; set; }
		/// <summary>
		/// 当天用户提现我方手续费
		/// 【字段 decimal(20,3)】
		/// </summary>
		[DataMember(Order = 39)]
		public decimal? CashOwnFee { get; set; }
		/// <summary>
		/// 当天用户的账户余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 40)]
		public long EndBalance { get; set; }
		/// <summary>
		/// 当天用户bonus余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 41)]
		public long EndBonus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 42)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 用户注册的ip
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 43)]
		public string UserIp { get; set; }
		/// <summary>
		/// 手机号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 44)]
		public string Mobile { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_user_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_user_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_user_dayEO ret = new Sr_user_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.UserKind = reader.ToInt32("UserKind");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.IsNew = reader.ToBoolean("IsNew");
			ret.IsLogin = reader.ToBoolean("IsLogin");
			ret.LoginDays = reader.ToInt32("LoginDays");
			ret.LastLoginTime = reader.ToDateTimeN("LastLoginTime");
			ret.IsRegister = reader.ToBoolean("IsRegister");
			ret.RegistDate = reader.ToDateTimeN("RegistDate");
			ret.IsNewBet = reader.ToBoolean("IsNewBet");
			ret.HasBet = reader.ToBoolean("HasBet");
			ret.IsNewPay = reader.ToBoolean("IsNewPay");
			ret.HasPay = reader.ToBoolean("HasPay");
			ret.IsNewCash = reader.ToBoolean("IsNewCash");
			ret.HasCash = reader.ToBoolean("HasCash");
			ret.BetCount = reader.ToInt32("BetCount");
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.BetBonus = reader.ToInt64("BetBonus");
			ret.WinCount = reader.ToInt32("WinCount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.WinBonus = reader.ToInt64("WinBonus");
			ret.PayCount = reader.ToInt32("PayCount");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.CashCount = reader.ToInt32("CashCount");
			ret.CashAmount = reader.ToInt64("CashAmount");
			ret.ActivityCount = reader.ToInt32("ActivityCount");
			ret.ActivityAmount = reader.ToInt64("ActivityAmount");
			ret.ChangeCount = reader.ToInt32("ChangeCount");
			ret.ChangeAmount = reader.ToInt64("ChangeAmount");
			ret.CashAuditAmount = reader.ToInt64("CashAuditAmount");
			ret.PayUserFee = reader.ToDecimal("PayUserFee");
			ret.PayOwnFee = reader.ToDecimal("PayOwnFee");
			ret.CashUserFee = reader.ToDecimal("CashUserFee");
			ret.CashOwnFee = reader.ToDecimalN("CashOwnFee");
			ret.EndBalance = reader.ToInt64("EndBalance");
			ret.EndBonus = reader.ToInt64("EndBonus");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.UserIp = reader.ToString("UserIp");
			ret.Mobile = reader.ToString("Mobile");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sr_user_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_user_dayMO : MySqlTableMO<Sr_user_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_user_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_user_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_user_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_user_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_user_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `UserID`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `FromMode`, `FromId`, `IsNew`, `IsLogin`, `LoginDays`, `LastLoginTime`, `IsRegister`, `RegistDate`, `IsNewBet`, `HasBet`, `IsNewPay`, `HasPay`, `IsNewCash`, `HasCash`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `PayCount`, `PayAmount`, `CashCount`, `CashAmount`, `ActivityCount`, `ActivityAmount`, `ChangeCount`, `ChangeAmount`, `CashAuditAmount`, `PayUserFee`, `PayOwnFee`, `CashUserFee`, `CashOwnFee`, `EndBalance`, `EndBonus`, `RecDate`, `UserIp`, `Mobile`) VALUE (@DayID, @UserID, @UserKind, @OperatorID, @CountryID, @CurrencyID, @FromMode, @FromId, @IsNew, @IsLogin, @LoginDays, @LastLoginTime, @IsRegister, @RegistDate, @IsNewBet, @HasBet, @IsNewPay, @HasPay, @IsNewCash, @HasCash, @BetCount, @BetAmount, @BetBonus, @WinCount, @WinAmount, @WinBonus, @PayCount, @PayAmount, @CashCount, @CashAmount, @ActivityCount, @ActivityAmount, @ChangeCount, @ChangeAmount, @CashAuditAmount, @PayUserFee, @PayOwnFee, @CashUserFee, @CashOwnFee, @EndBalance, @EndBonus, @RecDate, @UserIp, @Mobile);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsNew", item.IsNew, MySqlDbType.Byte),
				Database.CreateInParameter("@IsLogin", item.IsLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@LoginDays", item.LoginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginTime", item.LastLoginTime.HasValue ? item.LastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsRegister", item.IsRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsNewBet", item.IsNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewPay", item.IsNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewCash", item.IsNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@PayCount", item.PayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashCount", item.CashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ActivityCount", item.ActivityCount, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityAmount", item.ActivityAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeCount", item.ChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeAmount", item.ChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAuditAmount", item.CashAuditAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@PayUserFee", item.PayUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashOwnFee", item.CashOwnFee.HasValue ? item.CashOwnFee.Value : (object)DBNull.Value, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sr_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_user_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `UserID`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `FromMode`, `FromId`, `IsNew`, `IsLogin`, `LoginDays`, `LastLoginTime`, `IsRegister`, `RegistDate`, `IsNewBet`, `HasBet`, `IsNewPay`, `HasPay`, `IsNewCash`, `HasCash`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `PayCount`, `PayAmount`, `CashCount`, `CashAmount`, `ActivityCount`, `ActivityAmount`, `ChangeCount`, `ChangeAmount`, `CashAuditAmount`, `PayUserFee`, `PayOwnFee`, `CashUserFee`, `CashOwnFee`, `EndBalance`, `EndBonus`, `RecDate`, `UserIp`, `Mobile`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserID}',{item.UserKind},'{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.FromMode},'{item.FromId}',{item.IsNew},{item.IsLogin},{item.LoginDays},'{item.LastLoginTime?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.IsRegister},'{item.RegistDate?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.IsNewBet},{item.HasBet},{item.IsNewPay},{item.HasPay},{item.IsNewCash},{item.HasCash},{item.BetCount},{item.BetAmount},{item.BetBonus},{item.WinCount},{item.WinAmount},{item.WinBonus},{item.PayCount},{item.PayAmount},{item.CashCount},{item.CashAmount},{item.ActivityCount},{item.ActivityAmount},{item.ChangeCount},{item.ChangeAmount},{item.CashAuditAmount},{item.PayUserFee},{item.PayOwnFee},{item.CashUserFee},{item.CashOwnFee?.ToString()??null},{item.EndBalance},{item.EndBonus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserIp}','{item.Mobile}'),");
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_user_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_user_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserKind(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserKindData(int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserKind` = @UserKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserKind
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
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFromId
		#region RemoveByIsNew
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNew(bool isNew, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewData(isNew, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewAsync(bool isNew, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewData(isNew, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewData(bool isNew, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNew` = @IsNew";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNew
		#region RemoveByIsLogin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsLogin(bool isLogin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsLoginData(isLogin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsLoginAsync(bool isLogin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsLoginData(isLogin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsLoginData(bool isLogin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsLogin` = @IsLogin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsLogin
		#region RemoveByLoginDays
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLoginDays(int loginDays, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDaysData(loginDays, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLoginDaysAsync(int loginDays, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDaysData(loginDays, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLoginDaysData(int loginDays, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LoginDays` = @LoginDays";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
		}
		#endregion // RemoveByLoginDays
		#region RemoveByLastLoginTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginTimeData(lastLoginTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginTimeData(lastLoginTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastLoginTimeData(DateTime? lastLoginTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastLoginTime
		#region RemoveByIsRegister
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsRegister(bool isRegister, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegisterData(isRegister, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsRegisterAsync(bool isRegister, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegisterData(isRegister, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsRegisterData(bool isRegister, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsRegister` = @IsRegister";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsRegister
		#region RemoveByRegistDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegistDate(DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRegistDateData(registDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegistDateAsync(DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRegistDateData(registDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegistDateData(DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRegistDate
		#region RemoveByIsNewBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewBet(bool isNewBet, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewBetData(isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewBetAsync(bool isNewBet, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewBetData(isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewBetData(bool isNewBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewBet` = @IsNewBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewBet
		#region RemoveByHasBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasBet(bool hasBet, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBetData(hasBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasBetAsync(bool hasBet, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBetData(hasBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasBetData(bool hasBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasBet` = @HasBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasBet
		#region RemoveByIsNewPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewPay(bool isNewPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewPayData(isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewPayAsync(bool isNewPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewPayData(isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewPayData(bool isNewPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewPay` = @IsNewPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewPay
		#region RemoveByHasPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasPay(bool hasPay, TransactionManager tm_ = null)
		{
			RepairRemoveByHasPayData(hasPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasPayAsync(bool hasPay, TransactionManager tm_ = null)
		{
			RepairRemoveByHasPayData(hasPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasPayData(bool hasPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasPay` = @HasPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasPay
		#region RemoveByIsNewCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewCash(bool isNewCash, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewCashData(isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewCashAsync(bool isNewCash, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewCashData(isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewCashData(bool isNewCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewCash` = @IsNewCash";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewCash
		#region RemoveByHasCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasCash(bool hasCash, TransactionManager tm_ = null)
		{
			RepairRemoveByHasCashData(hasCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasCashAsync(bool hasCash, TransactionManager tm_ = null)
		{
			RepairRemoveByHasCashData(hasCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasCashData(bool hasCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasCash` = @HasCash";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasCash
		#region RemoveByBetCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetCount(int betCount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCountData(betCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetCountAsync(int betCount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCountData(betCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetCountData(int betCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetCount` = @BetCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetCount
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountData(long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmount` = @BetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetAmount
		#region RemoveByBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBonusData(long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBonus` = @BetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBonus
		#region RemoveByWinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinCount(int winCount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCountData(winCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinCountAsync(int winCount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCountData(winCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinCountData(int winCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinCount` = @WinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByWinCount
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinAmountData(long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinAmount` = @WinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinAmount
		#region RemoveByWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinBonusData(long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinBonus` = @WinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinBonus
		#region RemoveByPayCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayCount(int payCount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayCountData(payCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayCountAsync(int payCount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayCountData(payCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayCountData(int payCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayCount` = @PayCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByPayCount
		#region RemoveByPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
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
		#region RemoveByCashCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashCount(int cashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashCountData(cashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashCountAsync(int cashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashCountData(cashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashCountData(int cashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashCount` = @CashCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashCount
		#region RemoveByCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAmountData(long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashAmount` = @CashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashAmount
		#region RemoveByActivityCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityCount(int activityCount, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityCountData(activityCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityCountAsync(int activityCount, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityCountData(activityCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityCountData(int activityCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityCount` = @ActivityCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByActivityCount
		#region RemoveByActivityAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityAmount(long activityAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityAmountData(activityAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityAmountAsync(long activityAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityAmountData(activityAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityAmountData(long activityAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityAmount` = @ActivityAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByActivityAmount
		#region RemoveByChangeCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChangeCount(int changeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeCountData(changeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChangeCountAsync(int changeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeCountData(changeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChangeCountData(int changeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChangeCount` = @ChangeCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByChangeCount
		#region RemoveByChangeAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChangeAmount(long changeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeAmountData(changeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChangeAmountAsync(long changeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeAmountData(changeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChangeAmountData(long changeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChangeAmount` = @ChangeAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByChangeAmount
		#region RemoveByCashAuditAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAuditAmount(long cashAuditAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditAmountData(cashAuditAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAuditAmountAsync(long cashAuditAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditAmountData(cashAuditAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAuditAmountData(long cashAuditAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashAuditAmount` = @CashAuditAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashAuditAmount
		#region RemoveByPayUserFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayUserFee(decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUserFeeData(payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayUserFeeAsync(decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUserFeeData(payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayUserFeeData(decimal payUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayUserFee` = @PayUserFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByPayUserFee
		#region RemoveByPayOwnFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayOwnFee(decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayOwnFeeData(decimal payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayOwnFee` = @PayOwnFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByPayOwnFee
		#region RemoveByCashUserFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashUserFee(decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashUserFeeData(decimal cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashUserFee` = @CashUserFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByCashUserFee
		#region RemoveByCashOwnFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashOwnFee(decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashOwnFeeData(cashOwnFee.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashOwnFeeAsync(decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashOwnFeeData(cashOwnFee.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashOwnFeeData(decimal? cashOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cashOwnFee.HasValue ? "`CashOwnFee` = @CashOwnFee" : "`CashOwnFee` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cashOwnFee.HasValue)
				paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee.Value, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByCashOwnFee
		#region RemoveByEndBalance
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndBalance(long endBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBalanceData(endBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndBalanceAsync(long endBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBalanceData(endBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndBalanceData(long endBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndBalance` = @EndBalance";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
		}
		#endregion // RemoveByEndBalance
		#region RemoveByEndBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndBonus(long endBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBonusData(endBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndBonusAsync(long endBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBonusData(endBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndBonusData(long endBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndBonus` = @EndBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByEndBonus
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
		#region RemoveByUserIp
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserIp(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIpData(string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserIp
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
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#region RemoveByDayIDAndUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayIDAndUserID(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByDayIDAndUserIDData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAndUserIDAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByDayIDAndUserIDData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByDayIDAndUserIDData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // RemoveByDayIDAndUserID
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
		public int Put(Sr_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_user_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `UserID` = @UserID, `UserKind` = @UserKind, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `FromMode` = @FromMode, `FromId` = @FromId, `IsNew` = @IsNew, `IsLogin` = @IsLogin, `LoginDays` = @LoginDays, `LastLoginTime` = @LastLoginTime, `IsRegister` = @IsRegister, `RegistDate` = @RegistDate, `IsNewBet` = @IsNewBet, `HasBet` = @HasBet, `IsNewPay` = @IsNewPay, `HasPay` = @HasPay, `IsNewCash` = @IsNewCash, `HasCash` = @HasCash, `BetCount` = @BetCount, `BetAmount` = @BetAmount, `BetBonus` = @BetBonus, `WinCount` = @WinCount, `WinAmount` = @WinAmount, `WinBonus` = @WinBonus, `PayCount` = @PayCount, `PayAmount` = @PayAmount, `CashCount` = @CashCount, `CashAmount` = @CashAmount, `ActivityCount` = @ActivityCount, `ActivityAmount` = @ActivityAmount, `ChangeCount` = @ChangeCount, `ChangeAmount` = @ChangeAmount, `CashAuditAmount` = @CashAuditAmount, `PayUserFee` = @PayUserFee, `PayOwnFee` = @PayOwnFee, `CashUserFee` = @CashUserFee, `CashOwnFee` = @CashOwnFee, `EndBalance` = @EndBalance, `EndBonus` = @EndBonus, `UserIp` = @UserIp, `Mobile` = @Mobile WHERE `DayID` = @DayID_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsNew", item.IsNew, MySqlDbType.Byte),
				Database.CreateInParameter("@IsLogin", item.IsLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@LoginDays", item.LoginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginTime", item.LastLoginTime.HasValue ? item.LastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsRegister", item.IsRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsNewBet", item.IsNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewPay", item.IsNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewCash", item.IsNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@PayCount", item.PayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashCount", item.CashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ActivityCount", item.ActivityCount, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityAmount", item.ActivityAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeCount", item.ChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeAmount", item.ChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAuditAmount", item.CashAuditAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@PayUserFee", item.PayUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashOwnFee", item.CashOwnFee.HasValue ? item.CashOwnFee.Value : (object)DBNull.Value, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_user_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_user_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatValues(values_, dayID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatValues(values_, dayID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", tm_, ConcatValues(values_, dayID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", tm_, ConcatValues(values_, dayID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(DateTime dayID, string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(DateTime dayID, string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(DateTime dayID, string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKind(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserKind
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(DateTime dayID, string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(DateTime dayID, string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(DateTime dayID, string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(DateTime dayID, string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(DateTime dayID, string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(DateTime dayID, string userID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayID, string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayID, string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayID, string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(DateTime dayID, string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(DateTime dayID, string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(DateTime dayID, string userID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutFromId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(DateTime dayID, string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(DateTime dayID, string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(DateTime dayID, string userID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromId
		#region PutIsNew
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewByPK(DateTime dayID, string userID, bool isNew, TransactionManager tm_ = null)
		{
			RepairPutIsNewByPKData(dayID, userID, isNew, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewByPKAsync(DateTime dayID, string userID, bool isNew, TransactionManager tm_ = null)
		{
			RepairPutIsNewByPKData(dayID, userID, isNew, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewByPKData(DateTime dayID, string userID, bool isNew, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNew(bool isNew, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew";
			var parameter_ = Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewAsync(bool isNew, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew";
			var parameter_ = Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNew
		#region PutIsLogin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsLoginByPK(DateTime dayID, string userID, bool isLogin, TransactionManager tm_ = null)
		{
			RepairPutIsLoginByPKData(dayID, userID, isLogin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsLoginByPKAsync(DateTime dayID, string userID, bool isLogin, TransactionManager tm_ = null)
		{
			RepairPutIsLoginByPKData(dayID, userID, isLogin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsLoginByPKData(DateTime dayID, string userID, bool isLogin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsLogin(bool isLogin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin";
			var parameter_ = Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsLoginAsync(bool isLogin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin";
			var parameter_ = Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsLogin
		#region PutLoginDays
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDaysByPK(DateTime dayID, string userID, int loginDays, TransactionManager tm_ = null)
		{
			RepairPutLoginDaysByPKData(dayID, userID, loginDays, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLoginDaysByPKAsync(DateTime dayID, string userID, int loginDays, TransactionManager tm_ = null)
		{
			RepairPutLoginDaysByPKData(dayID, userID, loginDays, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLoginDaysByPKData(DateTime dayID, string userID, int loginDays, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDays(int loginDays, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays";
			var parameter_ = Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLoginDaysAsync(int loginDays, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays";
			var parameter_ = Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLoginDays
		#region PutLastLoginTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginTimeByPK(DateTime dayID, string userID, DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairPutLastLoginTimeByPKData(dayID, userID, lastLoginTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastLoginTimeByPKAsync(DateTime dayID, string userID, DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairPutLastLoginTimeByPKData(dayID, userID, lastLoginTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastLoginTimeByPKData(DateTime dayID, string userID, DateTime? lastLoginTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime";
			var parameter_ = Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime";
			var parameter_ = Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastLoginTime
		#region PutIsRegister
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegisterByPK(DateTime dayID, string userID, bool isRegister, TransactionManager tm_ = null)
		{
			RepairPutIsRegisterByPKData(dayID, userID, isRegister, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsRegisterByPKAsync(DateTime dayID, string userID, bool isRegister, TransactionManager tm_ = null)
		{
			RepairPutIsRegisterByPKData(dayID, userID, isRegister, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsRegisterByPKData(DateTime dayID, string userID, bool isRegister, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegister(bool isRegister, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister";
			var parameter_ = Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsRegisterAsync(bool isRegister, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister";
			var parameter_ = Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsRegister
		#region PutRegistDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDateByPK(DateTime dayID, string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(dayID, userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegistDateByPKAsync(DateTime dayID, string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(dayID, userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegistDateByPKData(DateTime dayID, string userID, DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDate(DateTime? registDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate";
			var parameter_ = Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegistDateAsync(DateTime? registDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate";
			var parameter_ = Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegistDate
		#region PutIsNewBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewBetByPK(DateTime dayID, string userID, bool isNewBet, TransactionManager tm_ = null)
		{
			RepairPutIsNewBetByPKData(dayID, userID, isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewBetByPKAsync(DateTime dayID, string userID, bool isNewBet, TransactionManager tm_ = null)
		{
			RepairPutIsNewBetByPKData(dayID, userID, isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewBetByPKData(DateTime dayID, string userID, bool isNewBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewBet(bool isNewBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet";
			var parameter_ = Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewBetAsync(bool isNewBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet";
			var parameter_ = Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewBet
		#region PutHasBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBetByPK(DateTime dayID, string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(dayID, userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasBetByPKAsync(DateTime dayID, string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(dayID, userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasBetByPKData(DateTime dayID, string userID, bool hasBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBet(bool hasBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet";
			var parameter_ = Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasBetAsync(bool hasBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet";
			var parameter_ = Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasBet
		#region PutIsNewPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewPayByPK(DateTime dayID, string userID, bool isNewPay, TransactionManager tm_ = null)
		{
			RepairPutIsNewPayByPKData(dayID, userID, isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewPayByPKAsync(DateTime dayID, string userID, bool isNewPay, TransactionManager tm_ = null)
		{
			RepairPutIsNewPayByPKData(dayID, userID, isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewPayByPKData(DateTime dayID, string userID, bool isNewPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewPay(bool isNewPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay";
			var parameter_ = Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewPayAsync(bool isNewPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay";
			var parameter_ = Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewPay
		#region PutHasPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasPayByPK(DateTime dayID, string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(dayID, userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasPayByPKAsync(DateTime dayID, string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(dayID, userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasPayByPKData(DateTime dayID, string userID, bool hasPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasPay(bool hasPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay";
			var parameter_ = Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasPayAsync(bool hasPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay";
			var parameter_ = Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasPay
		#region PutIsNewCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewCashByPK(DateTime dayID, string userID, bool isNewCash, TransactionManager tm_ = null)
		{
			RepairPutIsNewCashByPKData(dayID, userID, isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewCashByPKAsync(DateTime dayID, string userID, bool isNewCash, TransactionManager tm_ = null)
		{
			RepairPutIsNewCashByPKData(dayID, userID, isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewCashByPKData(DateTime dayID, string userID, bool isNewCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewCash(bool isNewCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash";
			var parameter_ = Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewCashAsync(bool isNewCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash";
			var parameter_ = Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewCash
		#region PutHasCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasCashByPK(DateTime dayID, string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(dayID, userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasCashByPKAsync(DateTime dayID, string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(dayID, userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasCashByPKData(DateTime dayID, string userID, bool hasCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasCash(bool hasCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash";
			var parameter_ = Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasCashAsync(bool hasCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash";
			var parameter_ = Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasCash
		#region PutBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCountByPK(DateTime dayID, string userID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayID, userID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCountByPKAsync(DateTime dayID, string userID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayID, userID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCountByPKData(DateTime dayID, string userID, int betCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCount(int betCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount";
			var parameter_ = Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetCountAsync(int betCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount";
			var parameter_ = Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetCount
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(DateTime dayID, string userID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayID, userID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(DateTime dayID, string userID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayID, userID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(DateTime dayID, string userID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmount
		#region PutBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusByPK(DateTime dayID, string userID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayID, userID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusByPKAsync(DateTime dayID, string userID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayID, userID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusByPKData(DateTime dayID, string userID, long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBonus
		#region PutWinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCountByPK(DateTime dayID, string userID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayID, userID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCountByPKAsync(DateTime dayID, string userID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayID, userID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCountByPKData(DateTime dayID, string userID, int winCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCount(int winCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount";
			var parameter_ = Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinCountAsync(int winCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount";
			var parameter_ = Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinCount
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(DateTime dayID, string userID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayID, userID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(DateTime dayID, string userID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayID, userID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(DateTime dayID, string userID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinAmount
		#region PutWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusByPK(DateTime dayID, string userID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayID, userID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusByPKAsync(DateTime dayID, string userID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayID, userID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusByPKData(DateTime dayID, string userID, long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinBonus
		#region PutPayCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayCountByPK(DateTime dayID, string userID, int payCount, TransactionManager tm_ = null)
		{
			RepairPutPayCountByPKData(dayID, userID, payCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayCountByPKAsync(DateTime dayID, string userID, int payCount, TransactionManager tm_ = null)
		{
			RepairPutPayCountByPKData(dayID, userID, payCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayCountByPKData(DateTime dayID, string userID, int payCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayCount` = @PayCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayCount(int payCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayCount` = @PayCount";
			var parameter_ = Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayCountAsync(int payCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayCount` = @PayCount";
			var parameter_ = Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayCount
		#region PutPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountByPK(DateTime dayID, string userID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(dayID, userID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountByPKAsync(DateTime dayID, string userID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(dayID, userID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountByPKData(DateTime dayID, string userID, long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
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
		#region PutCashCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashCountByPK(DateTime dayID, string userID, int cashCount, TransactionManager tm_ = null)
		{
			RepairPutCashCountByPKData(dayID, userID, cashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashCountByPKAsync(DateTime dayID, string userID, int cashCount, TransactionManager tm_ = null)
		{
			RepairPutCashCountByPKData(dayID, userID, cashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashCountByPKData(DateTime dayID, string userID, int cashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashCount` = @CashCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashCount(int cashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashCount` = @CashCount";
			var parameter_ = Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashCountAsync(int cashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashCount` = @CashCount";
			var parameter_ = Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashCount
		#region PutCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmountByPK(DateTime dayID, string userID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, userID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAmountByPKAsync(DateTime dayID, string userID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, userID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAmountByPKData(DateTime dayID, string userID, long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAmount
		#region PutActivityCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityCountByPK(DateTime dayID, string userID, int activityCount, TransactionManager tm_ = null)
		{
			RepairPutActivityCountByPKData(dayID, userID, activityCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityCountByPKAsync(DateTime dayID, string userID, int activityCount, TransactionManager tm_ = null)
		{
			RepairPutActivityCountByPKData(dayID, userID, activityCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityCountByPKData(DateTime dayID, string userID, int activityCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityCount` = @ActivityCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityCount(int activityCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityCount` = @ActivityCount";
			var parameter_ = Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityCountAsync(int activityCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityCount` = @ActivityCount";
			var parameter_ = Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityCount
		#region PutActivityAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityAmountByPK(DateTime dayID, string userID, long activityAmount, TransactionManager tm_ = null)
		{
			RepairPutActivityAmountByPKData(dayID, userID, activityAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityAmountByPKAsync(DateTime dayID, string userID, long activityAmount, TransactionManager tm_ = null)
		{
			RepairPutActivityAmountByPKData(dayID, userID, activityAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityAmountByPKData(DateTime dayID, string userID, long activityAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityAmount` = @ActivityAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityAmount(long activityAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityAmount` = @ActivityAmount";
			var parameter_ = Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityAmountAsync(long activityAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityAmount` = @ActivityAmount";
			var parameter_ = Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityAmount
		#region PutChangeCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeCountByPK(DateTime dayID, string userID, int changeCount, TransactionManager tm_ = null)
		{
			RepairPutChangeCountByPKData(dayID, userID, changeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChangeCountByPKAsync(DateTime dayID, string userID, int changeCount, TransactionManager tm_ = null)
		{
			RepairPutChangeCountByPKData(dayID, userID, changeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChangeCountByPKData(DateTime dayID, string userID, int changeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChangeCount` = @ChangeCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeCount(int changeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeCount` = @ChangeCount";
			var parameter_ = Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChangeCountAsync(int changeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeCount` = @ChangeCount";
			var parameter_ = Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChangeCount
		#region PutChangeAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeAmountByPK(DateTime dayID, string userID, long changeAmount, TransactionManager tm_ = null)
		{
			RepairPutChangeAmountByPKData(dayID, userID, changeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChangeAmountByPKAsync(DateTime dayID, string userID, long changeAmount, TransactionManager tm_ = null)
		{
			RepairPutChangeAmountByPKData(dayID, userID, changeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChangeAmountByPKData(DateTime dayID, string userID, long changeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChangeAmount` = @ChangeAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeAmount(long changeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeAmount` = @ChangeAmount";
			var parameter_ = Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChangeAmountAsync(long changeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeAmount` = @ChangeAmount";
			var parameter_ = Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChangeAmount
		#region PutCashAuditAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAuditAmountByPK(DateTime dayID, string userID, long cashAuditAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAuditAmountByPKData(dayID, userID, cashAuditAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAuditAmountByPKAsync(DateTime dayID, string userID, long cashAuditAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAuditAmountByPKData(dayID, userID, cashAuditAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAuditAmountByPKData(DateTime dayID, string userID, long cashAuditAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAuditAmount` = @CashAuditAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAuditAmount(long cashAuditAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAuditAmount` = @CashAuditAmount";
			var parameter_ = Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAuditAmountAsync(long cashAuditAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAuditAmount` = @CashAuditAmount";
			var parameter_ = Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAuditAmount
		#region PutPayUserFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUserFeeByPK(DateTime dayID, string userID, decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairPutPayUserFeeByPKData(dayID, userID, payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayUserFeeByPKAsync(DateTime dayID, string userID, decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairPutPayUserFeeByPKData(dayID, userID, payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayUserFeeByPKData(DateTime dayID, string userID, decimal payUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUserFee(decimal payUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee";
			var parameter_ = Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayUserFeeAsync(decimal payUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee";
			var parameter_ = Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayUserFee
		#region PutPayOwnFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFeeByPK(DateTime dayID, string userID, decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, userID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayOwnFeeByPKAsync(DateTime dayID, string userID, decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, userID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayOwnFeeByPKData(DateTime dayID, string userID, decimal payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFee(decimal payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayOwnFee
		#region PutCashUserFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFeeByPK(DateTime dayID, string userID, decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, userID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashUserFeeByPKAsync(DateTime dayID, string userID, decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, userID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashUserFeeByPKData(DateTime dayID, string userID, decimal cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFee(decimal cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashUserFee
		#region PutCashOwnFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashOwnFeeByPK(DateTime dayID, string userID, decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			RepairPutCashOwnFeeByPKData(dayID, userID, cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashOwnFeeByPKAsync(DateTime dayID, string userID, decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			RepairPutCashOwnFeeByPKData(dayID, userID, cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashOwnFeeByPKData(DateTime dayID, string userID, decimal? cashOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashOwnFee", cashOwnFee.HasValue ? cashOwnFee.Value : (object)DBNull.Value, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashOwnFee(decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee";
			var parameter_ = Database.CreateInParameter("@CashOwnFee", cashOwnFee.HasValue ? cashOwnFee.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashOwnFeeAsync(decimal? cashOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee";
			var parameter_ = Database.CreateInParameter("@CashOwnFee", cashOwnFee.HasValue ? cashOwnFee.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashOwnFee
		#region PutEndBalance
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBalanceByPK(DateTime dayID, string userID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(dayID, userID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBalanceByPKAsync(DateTime dayID, string userID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(dayID, userID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBalanceByPKData(DateTime dayID, string userID, long endBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBalance(long endBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance";
			var parameter_ = Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndBalanceAsync(long endBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance";
			var parameter_ = Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndBalance
		#region PutEndBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBonusByPK(DateTime dayID, string userID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(dayID, userID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBonusByPKAsync(DateTime dayID, string userID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(dayID, userID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBonusByPKData(DateTime dayID, string userID, long endBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBonus(long endBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus";
			var parameter_ = Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndBonusAsync(long endBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus";
			var parameter_ = Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndBonus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayID, string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(DateTime dayID, string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(dayID, userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(DateTime dayID, string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(dayID, userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(DateTime dayID, string userID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIp(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserIp
		#region PutMobile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobileByPK(DateTime dayID, string userID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(dayID, userID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMobileByPKAsync(DateTime dayID, string userID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(dayID, userID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMobileByPKData(DateTime dayID, string userID, string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sr_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID) == null)
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
		public async Task<bool> SetAsync(Sr_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID) == null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_user_dayEO GetByPK(DateTime dayID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<Sr_user_dayEO> GetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public Sr_user_dayEO GetByDayIDAndUserID(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepairGetByDayIDAndUserIDData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<Sr_user_dayEO> GetByDayIDAndUserIDAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepairGetByDayIDAndUserIDData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		private void RepairGetByDayIDAndUserIDData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `UserID` = @UserID", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNew（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNew`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNew`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsLogin（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsLoginByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsLogin`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsLoginByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsLogin`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LoginDays（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLoginDaysByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LoginDays`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetLoginDaysByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LoginDays`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastLoginTime（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLastLoginTimeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LastLoginTime`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetLastLoginTimeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LastLoginTime`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsRegister（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsRegisterByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsRegister`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsRegisterByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsRegister`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegistDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRegistDateByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RegistDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetRegistDateByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RegistDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewBet（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewBetByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewBetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasBet（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasBetByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasBetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewPay（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewPayByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewPayByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasPay（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasPayByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasPayByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewCash（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewCashByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewCashByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasCash（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasCashByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasCashByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetBetCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWinCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WinCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetWinCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WinCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPayCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PayCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetPayCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PayCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetPayAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CashCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetCashCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CashCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCashAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActivityCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ActivityCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetActivityCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ActivityCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetActivityAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ActivityAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetActivityAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ActivityAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChangeCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChangeCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ChangeCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetChangeCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ChangeCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChangeAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetChangeAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ChangeAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetChangeAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ChangeAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAuditAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashAuditAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashAuditAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCashAuditAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashAuditAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayUserFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetPayUserFeeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`PayUserFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<decimal> GetPayUserFeeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`PayUserFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayOwnFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetPayOwnFeeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`PayOwnFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<decimal> GetPayOwnFeeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`PayOwnFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashUserFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetCashUserFeeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`CashUserFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<decimal> GetCashUserFeeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`CashUserFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashOwnFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal? GetCashOwnFeeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal?)GetScalar("`CashOwnFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<decimal?> GetCashOwnFeeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (decimal?)await GetScalarAsync("`CashOwnFee`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBalance（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBalanceByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBalance`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetEndBalanceByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBalance`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetEndBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Mobile（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMobileByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Mobile`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetMobileByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Mobile`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<Sr_user_dayEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<Sr_user_dayEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByIsNew
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew)
		{
			return GetByIsNew(isNew, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew)
		{
			return await GetByIsNewAsync(isNew, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, TransactionManager tm_)
		{
			return GetByIsNew(isNew, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, int top_)
		{
			return GetByIsNew(isNew, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, int top_)
		{
			return await GetByIsNewAsync(isNew, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, int top_, TransactionManager tm_)
		{
			return GetByIsNew(isNew, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, int top_, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, string sort_)
		{
			return GetByIsNew(isNew, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, string sort_)
		{
			return await GetByIsNewAsync(isNew, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, string sort_, TransactionManager tm_)
		{
			return GetByIsNew(isNew, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNew(bool isNew, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNew` = @IsNew", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewAsync(bool isNew, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNew` = @IsNew", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNew
		#region GetByIsLogin
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin)
		{
			return GetByIsLogin(isLogin, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin)
		{
			return await GetByIsLoginAsync(isLogin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, int top_)
		{
			return GetByIsLogin(isLogin, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_)
		{
			return await GetByIsLoginAsync(isLogin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, int top_, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, string sort_)
		{
			return GetByIsLogin(isLogin, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, string sort_)
		{
			return await GetByIsLoginAsync(isLogin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, string sort_, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, string sort_, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsLogin(bool isLogin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsLogin` = @IsLogin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsLogin` = @IsLogin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsLogin
		#region GetByLoginDays
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays)
		{
			return GetByLoginDays(loginDays, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays)
		{
			return await GetByLoginDaysAsync(loginDays, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, int top_)
		{
			return GetByLoginDays(loginDays, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_)
		{
			return await GetByLoginDaysAsync(loginDays, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, int top_, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, string sort_)
		{
			return GetByLoginDays(loginDays, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, string sort_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, string sort_, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, string sort_, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLoginDays(int loginDays, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginDays` = @LoginDays", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginDays` = @LoginDays", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByLoginDays
		#region GetByLastLoginTime
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime)
		{
			return GetByLastLoginTime(lastLoginTime, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_)
		{
			return GetByLastLoginTime(lastLoginTime, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, string sort_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, string sort_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, string sort_, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, string sort_, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByLastLoginTime
		#region GetByIsRegister
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister)
		{
			return GetByIsRegister(isRegister, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister)
		{
			return await GetByIsRegisterAsync(isRegister, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, int top_)
		{
			return GetByIsRegister(isRegister, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_)
		{
			return await GetByIsRegisterAsync(isRegister, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, int top_, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, string sort_)
		{
			return GetByIsRegister(isRegister, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, string sort_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, string sort_, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, string sort_, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsRegister(bool isRegister, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegister` = @IsRegister", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegister` = @IsRegister", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsRegister
		#region GetByRegistDate
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate)
		{
			return GetByRegistDate(registDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, int top_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, string sort_)
		{
			return GetByRegistDate(registDate, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, string sort_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRegistDate(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByRegistDate
		#region GetByIsNewBet
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet)
		{
			return GetByIsNewBet(isNewBet, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, int top_)
		{
			return GetByIsNewBet(isNewBet, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_)
		{
			return await GetByIsNewBetAsync(isNewBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, int top_, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, string sort_)
		{
			return GetByIsNewBet(isNewBet, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, string sort_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, string sort_, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewBet(bool isNewBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewBet` = @IsNewBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewBet` = @IsNewBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewBet
		#region GetByHasBet
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet)
		{
			return GetByHasBet(hasBet, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, int top_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, int top_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, string sort_)
		{
			return GetByHasBet(hasBet, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, string sort_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, string sort_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, string sort_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasBet(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasBet
		#region GetByIsNewPay
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay)
		{
			return GetByIsNewPay(isNewPay, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, int top_)
		{
			return GetByIsNewPay(isNewPay, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_)
		{
			return await GetByIsNewPayAsync(isNewPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, int top_, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, string sort_)
		{
			return GetByIsNewPay(isNewPay, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, string sort_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, string sort_, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewPay(bool isNewPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewPay` = @IsNewPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewPay` = @IsNewPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewPay
		#region GetByHasPay
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay)
		{
			return GetByHasPay(hasPay, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, int top_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, int top_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, string sort_)
		{
			return GetByHasPay(hasPay, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, string sort_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, string sort_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, string sort_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasPay(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasPay
		#region GetByIsNewCash
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash)
		{
			return GetByIsNewCash(isNewCash, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, int top_)
		{
			return GetByIsNewCash(isNewCash, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_)
		{
			return await GetByIsNewCashAsync(isNewCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, int top_, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, string sort_)
		{
			return GetByIsNewCash(isNewCash, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, string sort_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, string sort_, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByIsNewCash(bool isNewCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewCash` = @IsNewCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewCash` = @IsNewCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewCash
		#region GetByHasCash
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash)
		{
			return GetByHasCash(hasCash, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, int top_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, int top_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, string sort_)
		{
			return GetByHasCash(hasCash, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, string sort_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, string sort_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, string sort_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByHasCash(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasCash
		#region GetByBetCount
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount)
		{
			return GetByBetCount(betCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, int top_)
		{
			return GetByBetCount(betCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, int top_)
		{
			return await GetByBetCountAsync(betCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, int top_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, int top_, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, string sort_)
		{
			return GetByBetCount(betCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, string sort_)
		{
			return await GetByBetCountAsync(betCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, string sort_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, string sort_, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetCount(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetCountAsync(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByBetCount
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, int top_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, string sort_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, string sort_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByBetBonusAsync(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByWinCount
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount)
		{
			return GetByWinCount(winCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, int top_)
		{
			return GetByWinCount(winCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, int top_)
		{
			return await GetByWinCountAsync(winCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, int top_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, int top_, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, string sort_)
		{
			return GetByWinCount(winCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, string sort_)
		{
			return await GetByWinCountAsync(winCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, string sort_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, string sort_, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinCount(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinCountAsync(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByWinCount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, int top_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, string sort_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, string sort_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByWinBonusAsync(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByPayCount
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount)
		{
			return GetByPayCount(payCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount)
		{
			return await GetByPayCountAsync(payCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, TransactionManager tm_)
		{
			return GetByPayCount(payCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, TransactionManager tm_)
		{
			return await GetByPayCountAsync(payCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, int top_)
		{
			return GetByPayCount(payCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, int top_)
		{
			return await GetByPayCountAsync(payCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, int top_, TransactionManager tm_)
		{
			return GetByPayCount(payCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, int top_, TransactionManager tm_)
		{
			return await GetByPayCountAsync(payCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, string sort_)
		{
			return GetByPayCount(payCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, string sort_)
		{
			return await GetByPayCountAsync(payCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, string sort_, TransactionManager tm_)
		{
			return GetByPayCount(payCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, string sort_, TransactionManager tm_)
		{
			return await GetByPayCountAsync(payCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayCount（字段） 查询
		/// </summary>
		/// /// <param name = "payCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayCount(int payCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCount` = @PayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayCountAsync(int payCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCount` = @PayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCount", payCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByPayCount
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, int top_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, string sort_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">当天用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayAmountAsync(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByCashCount
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount)
		{
			return GetByCashCount(cashCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount)
		{
			return await GetByCashCountAsync(cashCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, TransactionManager tm_)
		{
			return GetByCashCount(cashCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, TransactionManager tm_)
		{
			return await GetByCashCountAsync(cashCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, int top_)
		{
			return GetByCashCount(cashCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, int top_)
		{
			return await GetByCashCountAsync(cashCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, int top_, TransactionManager tm_)
		{
			return GetByCashCount(cashCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, int top_, TransactionManager tm_)
		{
			return await GetByCashCountAsync(cashCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, string sort_)
		{
			return GetByCashCount(cashCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, string sort_)
		{
			return await GetByCashCountAsync(cashCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, string sort_, TransactionManager tm_)
		{
			return GetByCashCount(cashCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, string sort_, TransactionManager tm_)
		{
			return await GetByCashCountAsync(cashCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashCount（字段） 查询
		/// </summary>
		/// /// <param name = "cashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashCount(int cashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashCount` = @CashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashCountAsync(int cashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashCount` = @CashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashCount", cashCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCashCount
		#region GetByCashAmount
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, int top_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, int top_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, string sort_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">当天用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAmount(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCashAmount
		#region GetByActivityCount
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount)
		{
			return GetByActivityCount(activityCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount)
		{
			return await GetByActivityCountAsync(activityCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, TransactionManager tm_)
		{
			return GetByActivityCount(activityCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, TransactionManager tm_)
		{
			return await GetByActivityCountAsync(activityCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, int top_)
		{
			return GetByActivityCount(activityCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, int top_)
		{
			return await GetByActivityCountAsync(activityCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, int top_, TransactionManager tm_)
		{
			return GetByActivityCount(activityCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, int top_, TransactionManager tm_)
		{
			return await GetByActivityCountAsync(activityCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, string sort_)
		{
			return GetByActivityCount(activityCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, string sort_)
		{
			return await GetByActivityCountAsync(activityCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, string sort_, TransactionManager tm_)
		{
			return GetByActivityCount(activityCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, string sort_, TransactionManager tm_)
		{
			return await GetByActivityCountAsync(activityCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCount（字段） 查询
		/// </summary>
		/// /// <param name = "activityCount">活动赠送bonus次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityCount(int activityCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityCount` = @ActivityCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityCountAsync(int activityCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityCount` = @ActivityCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCount", activityCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByActivityCount
		#region GetByActivityAmount
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount)
		{
			return GetByActivityAmount(activityAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount)
		{
			return await GetByActivityAmountAsync(activityAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, TransactionManager tm_)
		{
			return GetByActivityAmount(activityAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, TransactionManager tm_)
		{
			return await GetByActivityAmountAsync(activityAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, int top_)
		{
			return GetByActivityAmount(activityAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, int top_)
		{
			return await GetByActivityAmountAsync(activityAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, int top_, TransactionManager tm_)
		{
			return GetByActivityAmount(activityAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, int top_, TransactionManager tm_)
		{
			return await GetByActivityAmountAsync(activityAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, string sort_)
		{
			return GetByActivityAmount(activityAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, string sort_)
		{
			return await GetByActivityAmountAsync(activityAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, string sort_, TransactionManager tm_)
		{
			return GetByActivityAmount(activityAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, string sort_, TransactionManager tm_)
		{
			return await GetByActivityAmountAsync(activityAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityAmount（字段） 查询
		/// </summary>
		/// /// <param name = "activityAmount">活动赠送bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByActivityAmount(long activityAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityAmount` = @ActivityAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByActivityAmountAsync(long activityAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityAmount` = @ActivityAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityAmount", activityAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByActivityAmount
		#region GetByChangeCount
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount)
		{
			return GetByChangeCount(changeCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount)
		{
			return await GetByChangeCountAsync(changeCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, TransactionManager tm_)
		{
			return GetByChangeCount(changeCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, TransactionManager tm_)
		{
			return await GetByChangeCountAsync(changeCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, int top_)
		{
			return GetByChangeCount(changeCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, int top_)
		{
			return await GetByChangeCountAsync(changeCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, int top_, TransactionManager tm_)
		{
			return GetByChangeCount(changeCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, int top_, TransactionManager tm_)
		{
			return await GetByChangeCountAsync(changeCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, string sort_)
		{
			return GetByChangeCount(changeCount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, string sort_)
		{
			return await GetByChangeCountAsync(changeCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, string sort_, TransactionManager tm_)
		{
			return GetByChangeCount(changeCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, string sort_, TransactionManager tm_)
		{
			return await GetByChangeCountAsync(changeCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "changeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeCount(int changeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeCount` = @ChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeCountAsync(int changeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeCount` = @ChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeCount", changeCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByChangeCount
		#region GetByChangeAmount
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount)
		{
			return GetByChangeAmount(changeAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount)
		{
			return await GetByChangeAmountAsync(changeAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, TransactionManager tm_)
		{
			return GetByChangeAmount(changeAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, TransactionManager tm_)
		{
			return await GetByChangeAmountAsync(changeAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, int top_)
		{
			return GetByChangeAmount(changeAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, int top_)
		{
			return await GetByChangeAmountAsync(changeAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, int top_, TransactionManager tm_)
		{
			return GetByChangeAmount(changeAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, int top_, TransactionManager tm_)
		{
			return await GetByChangeAmountAsync(changeAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, string sort_)
		{
			return GetByChangeAmount(changeAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, string sort_)
		{
			return await GetByChangeAmountAsync(changeAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, string sort_, TransactionManager tm_)
		{
			return GetByChangeAmount(changeAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, string sort_, TransactionManager tm_)
		{
			return await GetByChangeAmountAsync(changeAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "changeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByChangeAmount(long changeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeAmount` = @ChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByChangeAmountAsync(long changeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeAmount` = @ChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeAmount", changeAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByChangeAmount
		#region GetByCashAuditAmount
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, TransactionManager tm_)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_)
		{
			return GetByCashAuditAmount(cashAuditAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, int top_)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, int top_, TransactionManager tm_)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, string sort_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, string sort_)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, string sort_, TransactionManager tm_)
		{
			return await GetByCashAuditAmountAsync(cashAuditAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提现待审金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAuditAmount` = @CashAuditAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashAuditAmountAsync(long cashAuditAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAuditAmount` = @CashAuditAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCashAuditAmount
		#region GetByPayUserFee
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, int top_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_)
		{
			return await GetByPayUserFeeAsync(payUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, int top_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, string sort_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, string sort_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, string sort_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, string sort_, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">当天用户充值手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayUserFee(decimal payUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUserFee` = @PayUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUserFee` = @PayUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByPayUserFee
		#region GetByPayOwnFee
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, string sort_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, string sort_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">当天用户充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByPayOwnFee
		#region GetByCashUserFee
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, int top_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, string sort_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, string sort_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">当天用户提现手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCashUserFee
		#region GetByCashOwnFee
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, int top_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, int top_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, int top_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, int top_, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, string sort_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, string sort_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, string sort_, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">当天用户提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByCashOwnFee(decimal? cashOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cashOwnFee.HasValue ? "`CashOwnFee` = @CashOwnFee" : "`CashOwnFee` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cashOwnFee.HasValue)
				paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee.Value, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByCashOwnFeeAsync(decimal? cashOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cashOwnFee.HasValue ? "`CashOwnFee` = @CashOwnFee" : "`CashOwnFee` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cashOwnFee.HasValue)
				paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee.Value, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByCashOwnFee
		#region GetByEndBalance
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, int top_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, int top_)
		{
			return await GetByEndBalanceAsync(endBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, int top_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, int top_, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, string sort_)
		{
			return GetByEndBalance(endBalance, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, string sort_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, string sort_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, string sort_, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">当天用户的账户余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBalance(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBalanceAsync(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByEndBalance
		#region GetByEndBonus
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, int top_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, int top_)
		{
			return await GetByEndBonusAsync(endBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, int top_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, int top_, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, string sort_)
		{
			return GetByEndBonus(endBonus, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, string sort_)
		{
			return await GetByEndBonusAsync(endBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, string sort_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, string sort_, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">当天用户bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByEndBonus(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByEndBonusAsync(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByEndBonus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, int top_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, string sort_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户注册的ip</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByMobile
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByMobile(string mobile)
		{
			return GetByMobile(mobile, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByMobile(string mobile, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByMobile(string mobile, int top_)
		{
			return GetByMobile(mobile, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, int top_)
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
		public List<Sr_user_dayEO> GetByMobile(string mobile, int top_, TransactionManager tm_)
		{
			return GetByMobile(mobile, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, int top_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_dayEO> GetByMobile(string mobile, string sort_)
		{
			return GetByMobile(mobile, 0, sort_, null);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, string sort_)
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
		public List<Sr_user_dayEO> GetByMobile(string mobile, string sort_, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, string sort_, TransactionManager tm_)
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
		public List<Sr_user_dayEO> GetByMobile(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_dayEO>> GetByMobileAsync(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_dayEO.MapDataReader);
		}
		#endregion // GetByMobile
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
