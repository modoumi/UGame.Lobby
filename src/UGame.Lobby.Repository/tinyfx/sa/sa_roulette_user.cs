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
	/// 幸运轮盘用户表
	/// 【表 sa_roulette_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette_userEO : IRowMapper<Sa_roulette_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette_userEO()
		{
			this.UserKind = 0;
			this.Freespin = 0;
			this.SumWinAmount = 0;
			this.FreespinRound = 0;
			this.IsRegPay = false;
			this.IsFirstPay = false;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
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
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码guid
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户类型
		///              0-未知
		///              1-普通用户
		///              2-开发用户
		///              3-线上测试用户（调用第三方扣减）
		///              4-线上测试用户（不调用第三方扣减）
		///              5-仿真用户
		///              6-接口联调用户
		///              9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int UserKind { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// freespin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Freespin { get; set; }
		/// <summary>
		/// 活动累计获得奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long SumWinAmount { get; set; }
		/// <summary>
		/// freespin轮数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int FreespinRound { get; set; }
		/// <summary>
		/// 是否发放过注册奖励
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 8)]
		public bool IsRegPay { get; set; }
		/// <summary>
		/// 是否发放过首充奖励
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool IsFirstPay { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette_userEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette_userEO ret = new Sa_roulette_userEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.UserKind = reader.ToInt32("UserKind");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Freespin = reader.ToInt32("Freespin");
			ret.SumWinAmount = reader.ToInt64("SumWinAmount");
			ret.FreespinRound = reader.ToInt32("FreespinRound");
			ret.IsRegPay = reader.ToBoolean("IsRegPay");
			ret.IsFirstPay = reader.ToBoolean("IsFirstPay");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 幸运轮盘用户表
	/// 【表 sa_roulette_user 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette_userMO : MySqlTableMO<Sa_roulette_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `UserKind`, `OperatorID`, `CurrencyID`, `Freespin`, `SumWinAmount`, `FreespinRound`, `IsRegPay`, `IsFirstPay`, `RecDate`) VALUE (@UserID, @UserKind, @OperatorID, @CurrencyID, @Freespin, @SumWinAmount, @FreespinRound, @IsRegPay, @IsFirstPay, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Freespin", item.Freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@SumWinAmount", item.SumWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FreespinRound", item.FreespinRound, MySqlDbType.Int32),
				Database.CreateInParameter("@IsRegPay", item.IsRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsFirstPay", item.IsFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `UserKind`, `OperatorID`, `CurrencyID`, `Freespin`, `SumWinAmount`, `FreespinRound`, `IsRegPay`, `IsFirstPay`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}',{item.UserKind},'{item.OperatorID}','{item.CurrencyID}',{item.Freespin},{item.SumWinAmount},{item.FreespinRound},{item.IsRegPay},{item.IsFirstPay},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_roulette_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
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
		#region RemoveBySumWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumWinAmount(long sumWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySumWinAmountData(sumWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumWinAmountAsync(long sumWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySumWinAmountData(sumWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumWinAmountData(long sumWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumWinAmount` = @SumWinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveBySumWinAmount
		#region RemoveByFreespinRound
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreespinRound(int freespinRound, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinRoundData(freespinRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreespinRoundAsync(int freespinRound, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinRoundData(freespinRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreespinRoundData(int freespinRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreespinRound` = @FreespinRound";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreespinRound
		#region RemoveByIsRegPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsRegPay(bool isRegPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegPayData(isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsRegPayAsync(bool isRegPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegPayData(isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsRegPayData(bool isRegPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsRegPay` = @IsRegPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsRegPay
		#region RemoveByIsFirstPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsFirstPay(bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFirstPayData(isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsFirstPayAsync(bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFirstPayData(isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsFirstPayData(bool isFirstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsFirstPay` = @IsFirstPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsFirstPay
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
		public int Put(Sa_roulette_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `UserKind` = @UserKind, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `Freespin` = @Freespin, `SumWinAmount` = @SumWinAmount, `FreespinRound` = @FreespinRound, `IsRegPay` = @IsRegPay, `IsFirstPay` = @IsFirstPay WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Freespin", item.Freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@SumWinAmount", item.SumWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FreespinRound", item.FreespinRound, MySqlDbType.Int32),
				Database.CreateInParameter("@IsRegPay", item.IsRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsFirstPay", item.IsFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
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
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
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
		#region PutFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinByPK(string userID, int freespin, TransactionManager tm_ = null)
		{
			RepairPutFreespinByPKData(userID, freespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreespinByPKAsync(string userID, int freespin, TransactionManager tm_ = null)
		{
			RepairPutFreespinByPKData(userID, freespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreespinByPKData(string userID, int freespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Freespin` = @Freespin  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
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
		#region PutSumWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumWinAmountByPK(string userID, long sumWinAmount, TransactionManager tm_ = null)
		{
			RepairPutSumWinAmountByPKData(userID, sumWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumWinAmountByPKAsync(string userID, long sumWinAmount, TransactionManager tm_ = null)
		{
			RepairPutSumWinAmountByPKData(userID, sumWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumWinAmountByPKData(string userID, long sumWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumWinAmount` = @SumWinAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumWinAmount(long sumWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumWinAmount` = @SumWinAmount";
			var parameter_ = Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumWinAmountAsync(long sumWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumWinAmount` = @SumWinAmount";
			var parameter_ = Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumWinAmount
		#region PutFreespinRound
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinRoundByPK(string userID, int freespinRound, TransactionManager tm_ = null)
		{
			RepairPutFreespinRoundByPKData(userID, freespinRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreespinRoundByPKAsync(string userID, int freespinRound, TransactionManager tm_ = null)
		{
			RepairPutFreespinRoundByPKData(userID, freespinRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreespinRoundByPKData(string userID, int freespinRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreespinRound` = @FreespinRound  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinRound(int freespinRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreespinRound` = @FreespinRound";
			var parameter_ = Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreespinRoundAsync(int freespinRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreespinRound` = @FreespinRound";
			var parameter_ = Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreespinRound
		#region PutIsRegPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegPayByPK(string userID, bool isRegPay, TransactionManager tm_ = null)
		{
			RepairPutIsRegPayByPKData(userID, isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsRegPayByPKAsync(string userID, bool isRegPay, TransactionManager tm_ = null)
		{
			RepairPutIsRegPayByPKData(userID, isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsRegPayByPKData(string userID, bool isRegPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegPay(bool isRegPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay";
			var parameter_ = Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsRegPayAsync(bool isRegPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay";
			var parameter_ = Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsRegPay
		#region PutIsFirstPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFirstPayByPK(string userID, bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairPutIsFirstPayByPKData(userID, isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsFirstPayByPKAsync(string userID, bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairPutIsFirstPayByPKData(userID, isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsFirstPayByPKData(string userID, bool isFirstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFirstPay(bool isFirstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay";
			var parameter_ = Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsFirstPayAsync(bool isFirstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay";
			var parameter_ = Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsFirstPay
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_roulette_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(Sa_roulette_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette_userEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<Sa_roulette_userEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Freespin（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreespinByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Freespin`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFreespinByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Freespin`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumWinAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSumWinAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SumWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetSumWinAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SumWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreespinRound（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreespinRoundByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FreespinRound`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFreespinRoundByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FreespinRound`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsRegPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsRegPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsRegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsRegPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsRegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsFirstPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsFirstPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsFirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsFirstPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsFirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_userEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_userEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByFreespin
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin)
		{
			return GetByFreespin(freespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin)
		{
			return await GetByFreespinAsync(freespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, TransactionManager tm_)
		{
			return GetByFreespin(freespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, int top_)
		{
			return GetByFreespin(freespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, int top_)
		{
			return await GetByFreespinAsync(freespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, int top_, TransactionManager tm_)
		{
			return GetByFreespin(freespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, int top_, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, string sort_)
		{
			return GetByFreespin(freespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, string sort_)
		{
			return await GetByFreespinAsync(freespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, string sort_, TransactionManager tm_)
		{
			return GetByFreespin(freespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, string sort_, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespin(int freespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Freespin` = @Freespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinAsync(int freespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Freespin` = @Freespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByFreespin
		#region GetBySumWinAmount
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount)
		{
			return GetBySumWinAmount(sumWinAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, TransactionManager tm_)
		{
			return GetBySumWinAmount(sumWinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, TransactionManager tm_)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, int top_)
		{
			return GetBySumWinAmount(sumWinAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, int top_)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, int top_, TransactionManager tm_)
		{
			return GetBySumWinAmount(sumWinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, int top_, TransactionManager tm_)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, string sort_)
		{
			return GetBySumWinAmount(sumWinAmount, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, string sort_)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, string sort_, TransactionManager tm_)
		{
			return GetBySumWinAmount(sumWinAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, string sort_, TransactionManager tm_)
		{
			return await GetBySumWinAmountAsync(sumWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sumWinAmount">活动累计获得奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetBySumWinAmount(long sumWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumWinAmount` = @SumWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetBySumWinAmountAsync(long sumWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumWinAmount` = @SumWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumWinAmount", sumWinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetBySumWinAmount
		#region GetByFreespinRound
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound)
		{
			return GetByFreespinRound(freespinRound, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound)
		{
			return await GetByFreespinRoundAsync(freespinRound, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, TransactionManager tm_)
		{
			return GetByFreespinRound(freespinRound, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, TransactionManager tm_)
		{
			return await GetByFreespinRoundAsync(freespinRound, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, int top_)
		{
			return GetByFreespinRound(freespinRound, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, int top_)
		{
			return await GetByFreespinRoundAsync(freespinRound, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, int top_, TransactionManager tm_)
		{
			return GetByFreespinRound(freespinRound, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, int top_, TransactionManager tm_)
		{
			return await GetByFreespinRoundAsync(freespinRound, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, string sort_)
		{
			return GetByFreespinRound(freespinRound, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, string sort_)
		{
			return await GetByFreespinRoundAsync(freespinRound, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, string sort_, TransactionManager tm_)
		{
			return GetByFreespinRound(freespinRound, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, string sort_, TransactionManager tm_)
		{
			return await GetByFreespinRoundAsync(freespinRound, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreespinRound（字段） 查询
		/// </summary>
		/// /// <param name = "freespinRound">freespin轮数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByFreespinRound(int freespinRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreespinRound` = @FreespinRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByFreespinRoundAsync(int freespinRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreespinRound` = @FreespinRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinRound", freespinRound, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByFreespinRound
		#region GetByIsRegPay
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay)
		{
			return GetByIsRegPay(isRegPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, int top_)
		{
			return GetByIsRegPay(isRegPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_)
		{
			return await GetByIsRegPayAsync(isRegPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, int top_, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, string sort_)
		{
			return GetByIsRegPay(isRegPay, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, string sort_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, string sort_, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsRegPay(bool isRegPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegPay` = @IsRegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegPay` = @IsRegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByIsRegPay
		#region GetByIsFirstPay
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay)
		{
			return GetByIsFirstPay(isFirstPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, int top_)
		{
			return GetByIsFirstPay(isFirstPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, int top_, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, string sort_)
		{
			return GetByIsFirstPay(isFirstPay, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, string sort_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, string sort_, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByIsFirstPay(bool isFirstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFirstPay` = @IsFirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFirstPay` = @IsFirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByIsFirstPay
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
