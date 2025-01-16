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
	/// 幸运轮盘奖励配置
	/// 【表 sa_roulette_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette_configEO : IRowMapper<Sa_roulette_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette_configEO()
		{
			this.RegisterFreespin = 0;
			this.FirstPayFreespin = 0;
			this.RaffleUsedFreespin = 0;
			this.RaffleCashAmount = 0;
			this.NewUserBetTag = 0;
			this.NewUserMaxBonus = 0;
			this.InGoldPool = 0f;
			this.InCashPool = 0f;
			this.GGRInFreespinPool = 0f;
			this.IsCashEnable = false;
			this.TipPayRoundMin = 0;
			this.TipPayRoundMax = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 注册赠送freespin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int RegisterFreespin { get; set; }
		/// <summary>
		/// 首充赠送freespin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FirstPayFreespin { get; set; }
		/// <summary>
		/// 抽奖消耗freespin数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int RaffleUsedFreespin { get; set; }
		/// <summary>
		/// 抽奖金额-真金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long RaffleCashAmount { get; set; }
		/// <summary>
		/// 新用户下注标签,小于此值作为判定新用户的条件之一
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long NewUserBetTag { get; set; }
		/// <summary>
		/// 新用户freespin时的奖励上限
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long NewUserMaxBonus { get; set; }
		/// <summary>
		/// 真金抽奖进入freespin的比例
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 10)]
		public float InGoldPool { get; set; }
		/// <summary>
		/// 真金抽奖进入真金奖池的比例
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 11)]
		public float InCashPool { get; set; }
		/// <summary>
		/// 
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 12)]
		public float GGRInFreespinPool { get; set; }
		/// <summary>
		/// 活动推荐的游戏AppId,多个以|分割
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 13)]
		public string RecommendGames { get; set; }
		/// <summary>
		/// 是否启用真金抽奖
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 14)]
		public bool IsCashEnable { get; set; }
		/// <summary>
		/// 提示未充值用户充值,轮数下限
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int TipPayRoundMin { get; set; }
		/// <summary>
		/// 提示未充值用户充值,轮数上限
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int TipPayRoundMax { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 17)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette_configEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette_configEO ret = new Sa_roulette_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.RegisterFreespin = reader.ToInt32("RegisterFreespin");
			ret.FirstPayFreespin = reader.ToInt32("FirstPayFreespin");
			ret.RaffleUsedFreespin = reader.ToInt32("RaffleUsedFreespin");
			ret.RaffleCashAmount = reader.ToInt64("RaffleCashAmount");
			ret.NewUserBetTag = reader.ToInt64("NewUserBetTag");
			ret.NewUserMaxBonus = reader.ToInt64("NewUserMaxBonus");
			ret.InGoldPool = reader.ToSingle("InGoldPool");
			ret.InCashPool = reader.ToSingle("InCashPool");
			ret.GGRInFreespinPool = reader.ToSingle("GGRInFreespinPool");
			ret.RecommendGames = reader.ToString("RecommendGames");
			ret.IsCashEnable = reader.ToBoolean("IsCashEnable");
			ret.TipPayRoundMin = reader.ToInt32("TipPayRoundMin");
			ret.TipPayRoundMax = reader.ToInt32("TipPayRoundMax");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 幸运轮盘奖励配置
	/// 【表 sa_roulette_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette_configMO : MySqlTableMO<Sa_roulette_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `RegisterFreespin`, `FirstPayFreespin`, `RaffleUsedFreespin`, `RaffleCashAmount`, `NewUserBetTag`, `NewUserMaxBonus`, `InGoldPool`, `InCashPool`, `GGRInFreespinPool`, `RecommendGames`, `IsCashEnable`, `TipPayRoundMin`, `TipPayRoundMax`, `RecDate`) VALUE (@OperatorID, @CountryId, @CurrencyID, @RegisterFreespin, @FirstPayFreespin, @RaffleUsedFreespin, @RaffleCashAmount, @NewUserBetTag, @NewUserMaxBonus, @InGoldPool, @InCashPool, @GGRInFreespinPool, @RecommendGames, @IsCashEnable, @TipPayRoundMin, @TipPayRoundMax, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RegisterFreespin", item.RegisterFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayFreespin", item.FirstPayFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleUsedFreespin", item.RaffleUsedFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleCashAmount", item.RaffleCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserBetTag", item.NewUserBetTag, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserMaxBonus", item.NewUserMaxBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@InGoldPool", item.InGoldPool, MySqlDbType.Float),
				Database.CreateInParameter("@InCashPool", item.InCashPool, MySqlDbType.Float),
				Database.CreateInParameter("@GGRInFreespinPool", item.GGRInFreespinPool, MySqlDbType.Float),
				Database.CreateInParameter("@RecommendGames", item.RecommendGames, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsCashEnable", item.IsCashEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@TipPayRoundMin", item.TipPayRoundMin, MySqlDbType.Int32),
				Database.CreateInParameter("@TipPayRoundMax", item.TipPayRoundMax, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `RegisterFreespin`, `FirstPayFreespin`, `RaffleUsedFreespin`, `RaffleCashAmount`, `NewUserBetTag`, `NewUserMaxBonus`, `InGoldPool`, `InCashPool`, `GGRInFreespinPool`, `RecommendGames`, `IsCashEnable`, `TipPayRoundMin`, `TipPayRoundMax`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.RegisterFreespin},{item.FirstPayFreespin},{item.RaffleUsedFreespin},{item.RaffleCashAmount},{item.NewUserBetTag},{item.NewUserMaxBonus},{item.InGoldPool},{item.InCashPool},{item.GGRInFreespinPool},'{item.RecommendGames}',{item.IsCashEnable},{item.TipPayRoundMin},{item.TipPayRoundMax},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_roulette_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByCountryId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryId(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIdData(string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountryId` = @CountryId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryId
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
		#region RemoveByRegisterFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegisterFreespin(int registerFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByRegisterFreespinData(registerFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegisterFreespinAsync(int registerFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByRegisterFreespinData(registerFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegisterFreespinData(int registerFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RegisterFreespin` = @RegisterFreespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32));
		}
		#endregion // RemoveByRegisterFreespin
		#region RemoveByFirstPayFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPayFreespin(int firstPayFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayFreespinData(firstPayFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayFreespinAsync(int firstPayFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayFreespinData(firstPayFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayFreespinData(int firstPayFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstPayFreespin` = @FirstPayFreespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32));
		}
		#endregion // RemoveByFirstPayFreespin
		#region RemoveByRaffleUsedFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRaffleUsedFreespin(int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleUsedFreespinData(raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRaffleUsedFreespinAsync(int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleUsedFreespinData(raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRaffleUsedFreespinData(int raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RaffleUsedFreespin` = @RaffleUsedFreespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32));
		}
		#endregion // RemoveByRaffleUsedFreespin
		#region RemoveByRaffleCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRaffleCashAmount(long raffleCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleCashAmountData(raffleCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRaffleCashAmountAsync(long raffleCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleCashAmountData(raffleCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRaffleCashAmountData(long raffleCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RaffleCashAmount` = @RaffleCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByRaffleCashAmount
		#region RemoveByNewUserBetTag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserBetTag(long newUserBetTag, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetTagData(newUserBetTag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserBetTagAsync(long newUserBetTag, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetTagData(newUserBetTag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserBetTagData(long newUserBetTag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserBetTag` = @NewUserBetTag";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserBetTag
		#region RemoveByNewUserMaxBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserMaxBonus(long newUserMaxBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserMaxBonusData(newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserMaxBonusAsync(long newUserMaxBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserMaxBonusData(newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserMaxBonusData(long newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserMaxBonus` = @NewUserMaxBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserMaxBonus
		#region RemoveByInGoldPool
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByInGoldPool(float inGoldPool, TransactionManager tm_ = null)
		{
			RepairRemoveByInGoldPoolData(inGoldPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByInGoldPoolAsync(float inGoldPool, TransactionManager tm_ = null)
		{
			RepairRemoveByInGoldPoolData(inGoldPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByInGoldPoolData(float inGoldPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `InGoldPool` = @InGoldPool";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float));
		}
		#endregion // RemoveByInGoldPool
		#region RemoveByInCashPool
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByInCashPool(float inCashPool, TransactionManager tm_ = null)
		{
			RepairRemoveByInCashPoolData(inCashPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByInCashPoolAsync(float inCashPool, TransactionManager tm_ = null)
		{
			RepairRemoveByInCashPoolData(inCashPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByInCashPoolData(float inCashPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `InCashPool` = @InCashPool";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float));
		}
		#endregion // RemoveByInCashPool
		#region RemoveByGGRInFreespinPool
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGGRInFreespinPool(float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			RepairRemoveByGGRInFreespinPoolData(gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGGRInFreespinPoolAsync(float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			RepairRemoveByGGRInFreespinPoolData(gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGGRInFreespinPoolData(float gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `GGRInFreespinPool` = @GGRInFreespinPool";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float));
		}
		#endregion // RemoveByGGRInFreespinPool
		#region RemoveByRecommendGames
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecommendGames(string recommendGames, TransactionManager tm_ = null)
		{
			RepairRemoveByRecommendGamesData(recommendGames, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecommendGamesAsync(string recommendGames, TransactionManager tm_ = null)
		{
			RepairRemoveByRecommendGamesData(recommendGames, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecommendGamesData(string recommendGames, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecommendGames` = @RecommendGames";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRecommendGames
		#region RemoveByIsCashEnable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsCashEnable(bool isCashEnable, TransactionManager tm_ = null)
		{
			RepairRemoveByIsCashEnableData(isCashEnable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsCashEnableAsync(bool isCashEnable, TransactionManager tm_ = null)
		{
			RepairRemoveByIsCashEnableData(isCashEnable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsCashEnableData(bool isCashEnable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsCashEnable` = @IsCashEnable";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsCashEnable
		#region RemoveByTipPayRoundMin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTipPayRoundMin(int tipPayRoundMin, TransactionManager tm_ = null)
		{
			RepairRemoveByTipPayRoundMinData(tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTipPayRoundMinAsync(int tipPayRoundMin, TransactionManager tm_ = null)
		{
			RepairRemoveByTipPayRoundMinData(tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTipPayRoundMinData(int tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TipPayRoundMin` = @TipPayRoundMin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32));
		}
		#endregion // RemoveByTipPayRoundMin
		#region RemoveByTipPayRoundMax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTipPayRoundMax(int tipPayRoundMax, TransactionManager tm_ = null)
		{
			RepairRemoveByTipPayRoundMaxData(tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTipPayRoundMaxAsync(int tipPayRoundMax, TransactionManager tm_ = null)
		{
			RepairRemoveByTipPayRoundMaxData(tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTipPayRoundMaxData(int tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TipPayRoundMax` = @TipPayRoundMax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32));
		}
		#endregion // RemoveByTipPayRoundMax
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
		public int Put(Sa_roulette_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `RegisterFreespin` = @RegisterFreespin, `FirstPayFreespin` = @FirstPayFreespin, `RaffleUsedFreespin` = @RaffleUsedFreespin, `RaffleCashAmount` = @RaffleCashAmount, `NewUserBetTag` = @NewUserBetTag, `NewUserMaxBonus` = @NewUserMaxBonus, `InGoldPool` = @InGoldPool, `InCashPool` = @InCashPool, `GGRInFreespinPool` = @GGRInFreespinPool, `RecommendGames` = @RecommendGames, `IsCashEnable` = @IsCashEnable, `TipPayRoundMin` = @TipPayRoundMin, `TipPayRoundMax` = @TipPayRoundMax WHERE `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RegisterFreespin", item.RegisterFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayFreespin", item.FirstPayFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleUsedFreespin", item.RaffleUsedFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleCashAmount", item.RaffleCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserBetTag", item.NewUserBetTag, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserMaxBonus", item.NewUserMaxBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@InGoldPool", item.InGoldPool, MySqlDbType.Float),
				Database.CreateInParameter("@InCashPool", item.InCashPool, MySqlDbType.Float),
				Database.CreateInParameter("@GGRInFreespinPool", item.GGRInFreespinPool, MySqlDbType.Float),
				Database.CreateInParameter("@RecommendGames", item.RecommendGames, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsCashEnable", item.IsCashEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@TipPayRoundMin", item.TipPayRoundMin, MySqlDbType.Int32),
				Database.CreateInParameter("@TipPayRoundMax", item.TipPayRoundMax, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string operatorID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string operatorID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string operatorID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryId(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryId
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		#region PutRegisterFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegisterFreespinByPK(string operatorID, int registerFreespin, TransactionManager tm_ = null)
		{
			RepairPutRegisterFreespinByPKData(operatorID, registerFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegisterFreespinByPKAsync(string operatorID, int registerFreespin, TransactionManager tm_ = null)
		{
			RepairPutRegisterFreespinByPKData(operatorID, registerFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegisterFreespinByPKData(string operatorID, int registerFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegisterFreespin` = @RegisterFreespin  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegisterFreespin(int registerFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegisterFreespin` = @RegisterFreespin";
			var parameter_ = Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegisterFreespinAsync(int registerFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegisterFreespin` = @RegisterFreespin";
			var parameter_ = Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegisterFreespin
		#region PutFirstPayFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayFreespinByPK(string operatorID, int firstPayFreespin, TransactionManager tm_ = null)
		{
			RepairPutFirstPayFreespinByPKData(operatorID, firstPayFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayFreespinByPKAsync(string operatorID, int firstPayFreespin, TransactionManager tm_ = null)
		{
			RepairPutFirstPayFreespinByPKData(operatorID, firstPayFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayFreespinByPKData(string operatorID, int firstPayFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPayFreespin` = @FirstPayFreespin  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayFreespin(int firstPayFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayFreespin` = @FirstPayFreespin";
			var parameter_ = Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayFreespinAsync(int firstPayFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayFreespin` = @FirstPayFreespin";
			var parameter_ = Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPayFreespin
		#region PutRaffleUsedFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleUsedFreespinByPK(string operatorID, int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			RepairPutRaffleUsedFreespinByPKData(operatorID, raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRaffleUsedFreespinByPKAsync(string operatorID, int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			RepairPutRaffleUsedFreespinByPKData(operatorID, raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRaffleUsedFreespinByPKData(string operatorID, int raffleUsedFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RaffleUsedFreespin` = @RaffleUsedFreespin  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleUsedFreespin(int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleUsedFreespin` = @RaffleUsedFreespin";
			var parameter_ = Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRaffleUsedFreespinAsync(int raffleUsedFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleUsedFreespin` = @RaffleUsedFreespin";
			var parameter_ = Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRaffleUsedFreespin
		#region PutRaffleCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleCashAmountByPK(string operatorID, long raffleCashAmount, TransactionManager tm_ = null)
		{
			RepairPutRaffleCashAmountByPKData(operatorID, raffleCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRaffleCashAmountByPKAsync(string operatorID, long raffleCashAmount, TransactionManager tm_ = null)
		{
			RepairPutRaffleCashAmountByPKData(operatorID, raffleCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRaffleCashAmountByPKData(string operatorID, long raffleCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RaffleCashAmount` = @RaffleCashAmount  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleCashAmount(long raffleCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleCashAmount` = @RaffleCashAmount";
			var parameter_ = Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRaffleCashAmountAsync(long raffleCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleCashAmount` = @RaffleCashAmount";
			var parameter_ = Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRaffleCashAmount
		#region PutNewUserBetTag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetTagByPK(string operatorID, long newUserBetTag, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetTagByPKData(operatorID, newUserBetTag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserBetTagByPKAsync(string operatorID, long newUserBetTag, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetTagByPKData(operatorID, newUserBetTag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserBetTagByPKData(string operatorID, long newUserBetTag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserBetTag` = @NewUserBetTag  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetTag(long newUserBetTag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetTag` = @NewUserBetTag";
			var parameter_ = Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserBetTagAsync(long newUserBetTag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetTag` = @NewUserBetTag";
			var parameter_ = Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserBetTag
		#region PutNewUserMaxBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserMaxBonusByPK(string operatorID, long newUserMaxBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserMaxBonusByPKData(operatorID, newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserMaxBonusByPKAsync(string operatorID, long newUserMaxBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserMaxBonusByPKData(operatorID, newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserMaxBonusByPKData(string operatorID, long newUserMaxBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserMaxBonus` = @NewUserMaxBonus  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserMaxBonus(long newUserMaxBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserMaxBonus` = @NewUserMaxBonus";
			var parameter_ = Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserMaxBonusAsync(long newUserMaxBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserMaxBonus` = @NewUserMaxBonus";
			var parameter_ = Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserMaxBonus
		#region PutInGoldPool
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInGoldPoolByPK(string operatorID, float inGoldPool, TransactionManager tm_ = null)
		{
			RepairPutInGoldPoolByPKData(operatorID, inGoldPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutInGoldPoolByPKAsync(string operatorID, float inGoldPool, TransactionManager tm_ = null)
		{
			RepairPutInGoldPoolByPKData(operatorID, inGoldPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutInGoldPoolByPKData(string operatorID, float inGoldPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `InGoldPool` = @InGoldPool  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInGoldPool(float inGoldPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InGoldPool` = @InGoldPool";
			var parameter_ = Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutInGoldPoolAsync(float inGoldPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InGoldPool` = @InGoldPool";
			var parameter_ = Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutInGoldPool
		#region PutInCashPool
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInCashPoolByPK(string operatorID, float inCashPool, TransactionManager tm_ = null)
		{
			RepairPutInCashPoolByPKData(operatorID, inCashPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutInCashPoolByPKAsync(string operatorID, float inCashPool, TransactionManager tm_ = null)
		{
			RepairPutInCashPoolByPKData(operatorID, inCashPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutInCashPoolByPKData(string operatorID, float inCashPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `InCashPool` = @InCashPool  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInCashPool(float inCashPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InCashPool` = @InCashPool";
			var parameter_ = Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutInCashPoolAsync(float inCashPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InCashPool` = @InCashPool";
			var parameter_ = Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutInCashPool
		#region PutGGRInFreespinPool
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGGRInFreespinPoolByPK(string operatorID, float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			RepairPutGGRInFreespinPoolByPKData(operatorID, gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGGRInFreespinPoolByPKAsync(string operatorID, float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			RepairPutGGRInFreespinPoolByPKData(operatorID, gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGGRInFreespinPoolByPKData(string operatorID, float gGRInFreespinPool, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GGRInFreespinPool` = @GGRInFreespinPool  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGGRInFreespinPool(float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GGRInFreespinPool` = @GGRInFreespinPool";
			var parameter_ = Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGGRInFreespinPoolAsync(float gGRInFreespinPool, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GGRInFreespinPool` = @GGRInFreespinPool";
			var parameter_ = Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGGRInFreespinPool
		#region PutRecommendGames
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecommendGamesByPK(string operatorID, string recommendGames, TransactionManager tm_ = null)
		{
			RepairPutRecommendGamesByPKData(operatorID, recommendGames, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecommendGamesByPKAsync(string operatorID, string recommendGames, TransactionManager tm_ = null)
		{
			RepairPutRecommendGamesByPKData(operatorID, recommendGames, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecommendGamesByPKData(string operatorID, string recommendGames, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecommendGames` = @RecommendGames  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecommendGames(string recommendGames, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecommendGames` = @RecommendGames";
			var parameter_ = Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecommendGamesAsync(string recommendGames, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecommendGames` = @RecommendGames";
			var parameter_ = Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecommendGames
		#region PutIsCashEnable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsCashEnableByPK(string operatorID, bool isCashEnable, TransactionManager tm_ = null)
		{
			RepairPutIsCashEnableByPKData(operatorID, isCashEnable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsCashEnableByPKAsync(string operatorID, bool isCashEnable, TransactionManager tm_ = null)
		{
			RepairPutIsCashEnableByPKData(operatorID, isCashEnable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsCashEnableByPKData(string operatorID, bool isCashEnable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsCashEnable` = @IsCashEnable  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsCashEnable(bool isCashEnable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsCashEnable` = @IsCashEnable";
			var parameter_ = Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsCashEnableAsync(bool isCashEnable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsCashEnable` = @IsCashEnable";
			var parameter_ = Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsCashEnable
		#region PutTipPayRoundMin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipPayRoundMinByPK(string operatorID, int tipPayRoundMin, TransactionManager tm_ = null)
		{
			RepairPutTipPayRoundMinByPKData(operatorID, tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTipPayRoundMinByPKAsync(string operatorID, int tipPayRoundMin, TransactionManager tm_ = null)
		{
			RepairPutTipPayRoundMinByPKData(operatorID, tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTipPayRoundMinByPKData(string operatorID, int tipPayRoundMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TipPayRoundMin` = @TipPayRoundMin  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipPayRoundMin(int tipPayRoundMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipPayRoundMin` = @TipPayRoundMin";
			var parameter_ = Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTipPayRoundMinAsync(int tipPayRoundMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipPayRoundMin` = @TipPayRoundMin";
			var parameter_ = Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTipPayRoundMin
		#region PutTipPayRoundMax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipPayRoundMaxByPK(string operatorID, int tipPayRoundMax, TransactionManager tm_ = null)
		{
			RepairPutTipPayRoundMaxByPKData(operatorID, tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTipPayRoundMaxByPKAsync(string operatorID, int tipPayRoundMax, TransactionManager tm_ = null)
		{
			RepairPutTipPayRoundMaxByPKData(operatorID, tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTipPayRoundMaxByPKData(string operatorID, int tipPayRoundMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TipPayRoundMax` = @TipPayRoundMax  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipPayRoundMax(int tipPayRoundMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipPayRoundMax` = @TipPayRoundMax";
			var parameter_ = Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTipPayRoundMaxAsync(int tipPayRoundMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipPayRoundMax` = @TipPayRoundMax";
			var parameter_ = Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTipPayRoundMax
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		public bool Set(Sa_roulette_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sa_roulette_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette_configEO GetByPK(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<Sa_roulette_configEO> GetByPKAsync(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegisterFreespin（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRegisterFreespinByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RegisterFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetRegisterFreespinByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RegisterFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPayFreespin（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFirstPayFreespinByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FirstPayFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFirstPayFreespinByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FirstPayFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RaffleUsedFreespin（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRaffleUsedFreespinByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RaffleUsedFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetRaffleUsedFreespinByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RaffleUsedFreespin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RaffleCashAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRaffleCashAmountByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`RaffleCashAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetRaffleCashAmountByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`RaffleCashAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserBetTag（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserBetTagByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserBetTag`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetNewUserBetTagByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserBetTag`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserMaxBonus（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserMaxBonusByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserMaxBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetNewUserMaxBonusByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserMaxBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 InGoldPool（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetInGoldPoolByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`InGoldPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<float> GetInGoldPoolByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`InGoldPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 InCashPool（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetInCashPoolByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`InCashPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<float> GetInCashPoolByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`InCashPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GGRInFreespinPool（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetGGRInFreespinPoolByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`GGRInFreespinPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<float> GetGGRInFreespinPoolByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`GGRInFreespinPool`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecommendGames（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRecommendGamesByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RecommendGames`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetRecommendGamesByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RecommendGames`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsCashEnable（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsCashEnableByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsCashEnable`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<bool> GetIsCashEnableByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsCashEnable`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TipPayRoundMin（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTipPayRoundMinByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TipPayRoundMin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetTipPayRoundMinByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TipPayRoundMin`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TipPayRoundMax（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTipPayRoundMaxByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TipPayRoundMax`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetTipPayRoundMaxByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TipPayRoundMax`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, int top_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, string sort_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByRegisterFreespin
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin)
		{
			return GetByRegisterFreespin(registerFreespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, TransactionManager tm_)
		{
			return GetByRegisterFreespin(registerFreespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, TransactionManager tm_)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, int top_)
		{
			return GetByRegisterFreespin(registerFreespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, int top_)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, int top_, TransactionManager tm_)
		{
			return GetByRegisterFreespin(registerFreespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, int top_, TransactionManager tm_)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, string sort_)
		{
			return GetByRegisterFreespin(registerFreespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, string sort_)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, string sort_, TransactionManager tm_)
		{
			return GetByRegisterFreespin(registerFreespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, string sort_, TransactionManager tm_)
		{
			return await GetByRegisterFreespinAsync(registerFreespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegisterFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "registerFreespin">注册赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRegisterFreespin(int registerFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegisterFreespin` = @RegisterFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRegisterFreespinAsync(int registerFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegisterFreespin` = @RegisterFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterFreespin", registerFreespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByRegisterFreespin
		#region GetByFirstPayFreespin
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin)
		{
			return GetByFirstPayFreespin(firstPayFreespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, TransactionManager tm_)
		{
			return GetByFirstPayFreespin(firstPayFreespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, TransactionManager tm_)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, int top_)
		{
			return GetByFirstPayFreespin(firstPayFreespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, int top_)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, int top_, TransactionManager tm_)
		{
			return GetByFirstPayFreespin(firstPayFreespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, string sort_)
		{
			return GetByFirstPayFreespin(firstPayFreespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, string sort_)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayFreespin(firstPayFreespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayFreespinAsync(firstPayFreespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFreespin">首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByFirstPayFreespin(int firstPayFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayFreespin` = @FirstPayFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByFirstPayFreespinAsync(int firstPayFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayFreespin` = @FirstPayFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFreespin", firstPayFreespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByFirstPayFreespin
		#region GetByRaffleUsedFreespin
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, TransactionManager tm_)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, TransactionManager tm_)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, int top_)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, int top_)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, int top_, TransactionManager tm_)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, int top_, TransactionManager tm_)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, string sort_)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, string sort_)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, string sort_, TransactionManager tm_)
		{
			return GetByRaffleUsedFreespin(raffleUsedFreespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, string sort_, TransactionManager tm_)
		{
			return await GetByRaffleUsedFreespinAsync(raffleUsedFreespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RaffleUsedFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "raffleUsedFreespin">抽奖消耗freespin数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleUsedFreespin(int raffleUsedFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleUsedFreespin` = @RaffleUsedFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleUsedFreespinAsync(int raffleUsedFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleUsedFreespin` = @RaffleUsedFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleUsedFreespin", raffleUsedFreespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByRaffleUsedFreespin
		#region GetByRaffleCashAmount
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount)
		{
			return GetByRaffleCashAmount(raffleCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, TransactionManager tm_)
		{
			return GetByRaffleCashAmount(raffleCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, TransactionManager tm_)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, int top_)
		{
			return GetByRaffleCashAmount(raffleCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, int top_)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, int top_, TransactionManager tm_)
		{
			return GetByRaffleCashAmount(raffleCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, string sort_)
		{
			return GetByRaffleCashAmount(raffleCashAmount, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, string sort_)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByRaffleCashAmount(raffleCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByRaffleCashAmountAsync(raffleCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RaffleCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "raffleCashAmount">抽奖金额-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRaffleCashAmount(long raffleCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleCashAmount` = @RaffleCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRaffleCashAmountAsync(long raffleCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleCashAmount` = @RaffleCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleCashAmount", raffleCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByRaffleCashAmount
		#region GetByNewUserBetTag
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag)
		{
			return GetByNewUserBetTag(newUserBetTag, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, TransactionManager tm_)
		{
			return GetByNewUserBetTag(newUserBetTag, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, TransactionManager tm_)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, int top_)
		{
			return GetByNewUserBetTag(newUserBetTag, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, int top_)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetTag(newUserBetTag, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, int top_, TransactionManager tm_)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, string sort_)
		{
			return GetByNewUserBetTag(newUserBetTag, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, string sort_)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetTag(newUserBetTag, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserBetTagAsync(newUserBetTag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetTag（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetTag">新用户下注标签,小于此值作为判定新用户的条件之一</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserBetTag(long newUserBetTag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetTag` = @NewUserBetTag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserBetTagAsync(long newUserBetTag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetTag` = @NewUserBetTag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetTag", newUserBetTag, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByNewUserBetTag
		#region GetByNewUserMaxBonus
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, TransactionManager tm_)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, TransactionManager tm_)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, int top_)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, int top_)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, int top_, TransactionManager tm_)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, int top_, TransactionManager tm_)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, string sort_)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, string sort_)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, string sort_, TransactionManager tm_)
		{
			return GetByNewUserMaxBonus(newUserMaxBonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserMaxBonusAsync(newUserMaxBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserMaxBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserMaxBonus">新用户freespin时的奖励上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByNewUserMaxBonus(long newUserMaxBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserMaxBonus` = @NewUserMaxBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByNewUserMaxBonusAsync(long newUserMaxBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserMaxBonus` = @NewUserMaxBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserMaxBonus", newUserMaxBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByNewUserMaxBonus
		#region GetByInGoldPool
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool)
		{
			return GetByInGoldPool(inGoldPool, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool)
		{
			return await GetByInGoldPoolAsync(inGoldPool, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, TransactionManager tm_)
		{
			return GetByInGoldPool(inGoldPool, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, TransactionManager tm_)
		{
			return await GetByInGoldPoolAsync(inGoldPool, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, int top_)
		{
			return GetByInGoldPool(inGoldPool, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, int top_)
		{
			return await GetByInGoldPoolAsync(inGoldPool, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, int top_, TransactionManager tm_)
		{
			return GetByInGoldPool(inGoldPool, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, int top_, TransactionManager tm_)
		{
			return await GetByInGoldPoolAsync(inGoldPool, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, string sort_)
		{
			return GetByInGoldPool(inGoldPool, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, string sort_)
		{
			return await GetByInGoldPoolAsync(inGoldPool, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, string sort_, TransactionManager tm_)
		{
			return GetByInGoldPool(inGoldPool, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, string sort_, TransactionManager tm_)
		{
			return await GetByInGoldPoolAsync(inGoldPool, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 InGoldPool（字段） 查询
		/// </summary>
		/// /// <param name = "inGoldPool">真金抽奖进入freespin的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInGoldPool(float inGoldPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InGoldPool` = @InGoldPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInGoldPoolAsync(float inGoldPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InGoldPool` = @InGoldPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InGoldPool", inGoldPool, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByInGoldPool
		#region GetByInCashPool
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool)
		{
			return GetByInCashPool(inCashPool, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool)
		{
			return await GetByInCashPoolAsync(inCashPool, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, TransactionManager tm_)
		{
			return GetByInCashPool(inCashPool, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, TransactionManager tm_)
		{
			return await GetByInCashPoolAsync(inCashPool, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, int top_)
		{
			return GetByInCashPool(inCashPool, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, int top_)
		{
			return await GetByInCashPoolAsync(inCashPool, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, int top_, TransactionManager tm_)
		{
			return GetByInCashPool(inCashPool, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, int top_, TransactionManager tm_)
		{
			return await GetByInCashPoolAsync(inCashPool, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, string sort_)
		{
			return GetByInCashPool(inCashPool, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, string sort_)
		{
			return await GetByInCashPoolAsync(inCashPool, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, string sort_, TransactionManager tm_)
		{
			return GetByInCashPool(inCashPool, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, string sort_, TransactionManager tm_)
		{
			return await GetByInCashPoolAsync(inCashPool, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 InCashPool（字段） 查询
		/// </summary>
		/// /// <param name = "inCashPool">真金抽奖进入真金奖池的比例</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByInCashPool(float inCashPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InCashPool` = @InCashPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByInCashPoolAsync(float inCashPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InCashPool` = @InCashPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InCashPool", inCashPool, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByInCashPool
		#region GetByGGRInFreespinPool
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, TransactionManager tm_)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, TransactionManager tm_)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, int top_)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, int top_)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, int top_, TransactionManager tm_)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, int top_, TransactionManager tm_)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, string sort_)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, string sort_)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, string sort_, TransactionManager tm_)
		{
			return GetByGGRInFreespinPool(gGRInFreespinPool, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, string sort_, TransactionManager tm_)
		{
			return await GetByGGRInFreespinPoolAsync(gGRInFreespinPool, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GGRInFreespinPool（字段） 查询
		/// </summary>
		/// /// <param name = "gGRInFreespinPool"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByGGRInFreespinPool(float gGRInFreespinPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GGRInFreespinPool` = @GGRInFreespinPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByGGRInFreespinPoolAsync(float gGRInFreespinPool, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GGRInFreespinPool` = @GGRInFreespinPool", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GGRInFreespinPool", gGRInFreespinPool, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByGGRInFreespinPool
		#region GetByRecommendGames
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames)
		{
			return GetByRecommendGames(recommendGames, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames)
		{
			return await GetByRecommendGamesAsync(recommendGames, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, TransactionManager tm_)
		{
			return GetByRecommendGames(recommendGames, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, TransactionManager tm_)
		{
			return await GetByRecommendGamesAsync(recommendGames, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, int top_)
		{
			return GetByRecommendGames(recommendGames, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, int top_)
		{
			return await GetByRecommendGamesAsync(recommendGames, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, int top_, TransactionManager tm_)
		{
			return GetByRecommendGames(recommendGames, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, int top_, TransactionManager tm_)
		{
			return await GetByRecommendGamesAsync(recommendGames, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, string sort_)
		{
			return GetByRecommendGames(recommendGames, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, string sort_)
		{
			return await GetByRecommendGamesAsync(recommendGames, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, string sort_, TransactionManager tm_)
		{
			return GetByRecommendGames(recommendGames, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, string sort_, TransactionManager tm_)
		{
			return await GetByRecommendGamesAsync(recommendGames, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecommendGames（字段） 查询
		/// </summary>
		/// /// <param name = "recommendGames">活动推荐的游戏AppId,多个以|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecommendGames(string recommendGames, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecommendGames` = @RecommendGames", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecommendGamesAsync(string recommendGames, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecommendGames` = @RecommendGames", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecommendGames", recommendGames, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByRecommendGames
		#region GetByIsCashEnable
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable)
		{
			return GetByIsCashEnable(isCashEnable, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable)
		{
			return await GetByIsCashEnableAsync(isCashEnable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, TransactionManager tm_)
		{
			return GetByIsCashEnable(isCashEnable, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, TransactionManager tm_)
		{
			return await GetByIsCashEnableAsync(isCashEnable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, int top_)
		{
			return GetByIsCashEnable(isCashEnable, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, int top_)
		{
			return await GetByIsCashEnableAsync(isCashEnable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, int top_, TransactionManager tm_)
		{
			return GetByIsCashEnable(isCashEnable, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, int top_, TransactionManager tm_)
		{
			return await GetByIsCashEnableAsync(isCashEnable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, string sort_)
		{
			return GetByIsCashEnable(isCashEnable, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, string sort_)
		{
			return await GetByIsCashEnableAsync(isCashEnable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, string sort_, TransactionManager tm_)
		{
			return GetByIsCashEnable(isCashEnable, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, string sort_, TransactionManager tm_)
		{
			return await GetByIsCashEnableAsync(isCashEnable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsCashEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isCashEnable">是否启用真金抽奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByIsCashEnable(bool isCashEnable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsCashEnable` = @IsCashEnable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByIsCashEnableAsync(bool isCashEnable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsCashEnable` = @IsCashEnable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCashEnable", isCashEnable, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByIsCashEnable
		#region GetByTipPayRoundMin
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, TransactionManager tm_)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, TransactionManager tm_)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, int top_)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, int top_)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, int top_, TransactionManager tm_)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, int top_, TransactionManager tm_)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, string sort_)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, string sort_)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, string sort_, TransactionManager tm_)
		{
			return GetByTipPayRoundMin(tipPayRoundMin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, string sort_, TransactionManager tm_)
		{
			return await GetByTipPayRoundMinAsync(tipPayRoundMin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMin（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMin">提示未充值用户充值,轮数下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMin(int tipPayRoundMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipPayRoundMin` = @TipPayRoundMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMinAsync(int tipPayRoundMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipPayRoundMin` = @TipPayRoundMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMin", tipPayRoundMin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByTipPayRoundMin
		#region GetByTipPayRoundMax
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, TransactionManager tm_)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, TransactionManager tm_)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, int top_)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, int top_)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, int top_, TransactionManager tm_)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, int top_, TransactionManager tm_)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, string sort_)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, string sort_)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, string sort_, TransactionManager tm_)
		{
			return GetByTipPayRoundMax(tipPayRoundMax, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, string sort_, TransactionManager tm_)
		{
			return await GetByTipPayRoundMaxAsync(tipPayRoundMax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TipPayRoundMax（字段） 查询
		/// </summary>
		/// /// <param name = "tipPayRoundMax">提示未充值用户充值,轮数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByTipPayRoundMax(int tipPayRoundMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipPayRoundMax` = @TipPayRoundMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByTipPayRoundMaxAsync(int tipPayRoundMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipPayRoundMax` = @TipPayRoundMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipPayRoundMax", tipPayRoundMax, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByTipPayRoundMax
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
