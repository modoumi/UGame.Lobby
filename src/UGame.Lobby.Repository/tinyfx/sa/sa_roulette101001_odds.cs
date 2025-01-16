/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:11
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
	/// 1.7版抽奖轮盘抽奖概率
	/// 【表 sa_roulette101001_odds 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette101001_oddsEO : IRowMapper<Sa_roulette101001_oddsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette101001_oddsEO()
		{
			this.RewardType = 0;
			this.Position = 0;
			this.Odds = 0;
			this.Bonus = 0;
			this.OrderNum = 0;
			this.FlowMultip = 1.00f;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOddsID;
		/// <summary>
		/// 【数据库中的原始主键 OddsID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOddsID
		{
			get { return _originalOddsID; }
			set { HasOriginal = true; _originalOddsID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OddsID", OddsID }, };
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
		public string OddsID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 奖励类型1-无奖励2-bonus3-手机4-汽车
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int RewardType { get; set; }
		/// <summary>
		/// 奖励描述
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 6)]
		public string RewardTypeDesc { get; set; }
		/// <summary>
		/// 位置
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Position { get; set; }
		/// <summary>
		/// 概率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Odds { get; set; }
		/// <summary>
		/// 奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long Bonus { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 赠金提现所需要的流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 11)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette101001_oddsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette101001_oddsEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette101001_oddsEO ret = new Sa_roulette101001_oddsEO();
			ret.OddsID = reader.ToString("OddsID");
			ret.OriginalOddsID = ret.OddsID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.RewardType = reader.ToInt32("RewardType");
			ret.RewardTypeDesc = reader.ToString("RewardTypeDesc");
			ret.Position = reader.ToInt32("Position");
			ret.Odds = reader.ToInt32("Odds");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版抽奖轮盘抽奖概率
	/// 【表 sa_roulette101001_odds 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette101001_oddsMO : MySqlTableMO<Sa_roulette101001_oddsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette101001_odds`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette101001_oddsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette101001_oddsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette101001_oddsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette101001_oddsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OddsID`, `OperatorID`, `CountryID`, `CurrencyID`, `RewardType`, `RewardTypeDesc`, `Position`, `Odds`, `Bonus`, `OrderNum`, `FlowMultip`, `RecDate`) VALUE (@OddsID, @OperatorID, @CountryID, @CurrencyID, @RewardType, @RewardTypeDesc, @Position, @Odds, @Bonus, @OrderNum, @FlowMultip, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", item.OddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardTypeDesc", item.RewardTypeDesc != null ? item.RewardTypeDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette101001_oddsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette101001_oddsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette101001_oddsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OddsID`, `OperatorID`, `CountryID`, `CurrencyID`, `RewardType`, `RewardTypeDesc`, `Position`, `Odds`, `Bonus`, `OrderNum`, `FlowMultip`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OddsID}','{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.RewardType},'{item.RewardTypeDesc}',{item.Position},{item.Odds},{item.Bonus},{item.OrderNum},{item.FlowMultip},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string oddsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(oddsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(oddsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string oddsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OddsID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OddsID, tm_);
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
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>();
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
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
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
		#region RemoveByRewardTypeDesc
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardTypeDesc(string rewardTypeDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeDescData(rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardTypeDescAsync(string rewardTypeDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeDescData(rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardTypeDescData(string rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardTypeDesc != null ? "`RewardTypeDesc` = @RewardTypeDesc" : "`RewardTypeDesc` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardTypeDesc != null)
				paras_.Add(Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardTypeDesc
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
		#region RemoveByOdds
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOdds(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOddsAsync(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOddsData(int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Odds` = @Odds";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
		}
		#endregion // RemoveByOdds
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
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderNum` = @OrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
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
		public int Put(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette101001_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette101001_oddsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OddsID` = @OddsID, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `RewardType` = @RewardType, `RewardTypeDesc` = @RewardTypeDesc, `Position` = @Position, `Odds` = @Odds, `Bonus` = @Bonus, `OrderNum` = @OrderNum, `FlowMultip` = @FlowMultip WHERE `OddsID` = @OddsID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", item.OddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardTypeDesc", item.RewardTypeDesc != null ? item.RewardTypeDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@OddsID_Original", item.HasOriginal ? item.OriginalOddsID : item.OddsID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette101001_oddsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette101001_oddsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string oddsID, string set_, params object[] values_)
		{
			return Put(set_, "`OddsID` = @OddsID", ConcatValues(values_, oddsID));
		}
		public async Task<int> PutByPKAsync(string oddsID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OddsID` = @OddsID", ConcatValues(values_, oddsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string oddsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OddsID` = @OddsID", tm_, ConcatValues(values_, oddsID));
		}
		public async Task<int> PutByPKAsync(string oddsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OddsID` = @OddsID", tm_, ConcatValues(values_, oddsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string oddsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OddsID` = @OddsID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string oddsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OddsID` = @OddsID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string oddsID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(oddsID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string oddsID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(oddsID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string oddsID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string oddsID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(oddsID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string oddsID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(oddsID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string oddsID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string oddsID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(oddsID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string oddsID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(oddsID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string oddsID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(string oddsID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(oddsID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(string oddsID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(oddsID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(string oddsID, int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
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
		#region PutRewardTypeDesc
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeDescByPK(string oddsID, string rewardTypeDesc, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeDescByPKData(oddsID, rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeDescByPKAsync(string oddsID, string rewardTypeDesc, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeDescByPKData(oddsID, rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeDescByPKData(string oddsID, string rewardTypeDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardTypeDesc` = @RewardTypeDesc  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc != null ? rewardTypeDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeDesc(string rewardTypeDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardTypeDesc` = @RewardTypeDesc";
			var parameter_ = Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc != null ? rewardTypeDesc : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardTypeDescAsync(string rewardTypeDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardTypeDesc` = @RewardTypeDesc";
			var parameter_ = Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc != null ? rewardTypeDesc : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardTypeDesc
		#region PutPosition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPositionByPK(string oddsID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(oddsID, position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPositionByPKAsync(string oddsID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(oddsID, position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPositionByPKData(string oddsID, int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Position` = @Position  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
		#region PutOdds
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "odds">概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOddsByPK(string oddsID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(oddsID, odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOddsByPKAsync(string oddsID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(oddsID, odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOddsByPKData(string oddsID, int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Odds` = @Odds  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOdds(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOddsAsync(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOdds
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "bonus">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string oddsID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(oddsID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string oddsID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(oddsID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string oddsID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string oddsID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(oddsID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string oddsID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(oddsID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string oddsID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string oddsID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(oddsID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string oddsID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(oddsID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string oddsID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string oddsID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(oddsID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string oddsID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(oddsID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string oddsID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OddsID` = @OddsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
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
		public bool Set(Sa_roulette101001_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OddsID) == null)
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
		public async Task<bool> SetAsync(Sa_roulette101001_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OddsID) == null)
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
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette101001_oddsEO GetByPK(string oddsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(oddsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<Sa_roulette101001_oddsEO> GetByPKAsync(string oddsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(oddsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		private void RepairGetByPKData(string oddsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OddsID` = @OddsID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRewardTypeByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RewardType`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<int> GetRewardTypeByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RewardType`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardTypeDesc（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardTypeDescByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RewardTypeDesc`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<string> GetRewardTypeDescByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RewardTypeDesc`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Position`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Position`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Odds（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOddsByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Odds`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<int> GetOddsByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Odds`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`OddsID` = @OddsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "oddsID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OddsID` = @OddsID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string oddsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OddsID", oddsID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OddsID` = @OddsID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-bonus3-手机4-汽车</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByRewardTypeDesc
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, TransactionManager tm_)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, TransactionManager tm_)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, int top_)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, int top_)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, int top_, TransactionManager tm_)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, string sort_)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, string sort_)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, string sort_, TransactionManager tm_)
		{
			return GetByRewardTypeDesc(rewardTypeDesc, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeDescAsync(rewardTypeDesc, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardTypeDesc（字段） 查询
		/// </summary>
		/// /// <param name = "rewardTypeDesc">奖励描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRewardTypeDesc(string rewardTypeDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardTypeDesc != null ? "`RewardTypeDesc` = @RewardTypeDesc" : "`RewardTypeDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardTypeDesc != null)
				paras_.Add(Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRewardTypeDescAsync(string rewardTypeDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardTypeDesc != null ? "`RewardTypeDesc` = @RewardTypeDesc" : "`RewardTypeDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardTypeDesc != null)
				paras_.Add(Database.CreateInParameter("@RewardTypeDesc", rewardTypeDesc, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByRewardTypeDesc
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByOdds
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds)
		{
			return GetByOdds(odds, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, int top_)
		{
			return GetByOdds(odds, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, int top_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, int top_, TransactionManager tm_)
		{
			return GetByOdds(odds, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, int top_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, string sort_)
		{
			return GetByOdds(odds, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, string sort_)
		{
			return await GetByOddsAsync(odds, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, string sort_, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, string sort_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOdds(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOddsAsync(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByOdds
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_oddsEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_oddsEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
