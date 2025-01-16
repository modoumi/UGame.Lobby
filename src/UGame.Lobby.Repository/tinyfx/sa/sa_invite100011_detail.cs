/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:59
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
	/// 邀请人首充奖励明细
	/// 【表 sa_invite100011_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_invite100011_detailEO : IRowMapper<Sa_invite100011_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_invite100011_detailEO()
		{
			this.RewardType = 0;
			this.PUserKind = 0;
			this.Bonus = 0;
			this.FlowMultip = 0.00f;
			this.UserKind = 0;
			this.FirstPayAmount = 0;
			this.RecDate = DateTime.Now;
			this.ValidUserCount = 0;
			this.ReceiveStatus = false;
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
		/// 主键guid
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DetailID { get; set; }
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
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 0-预留值1-首充奖励2-邀请人数奖励
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int RewardType { get; set; }
		/// <summary>
		/// 邀请人
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 6)]
		public string PUserID { get; set; }
		/// <summary>
		/// 邀请人用户类型
		///                           0-未知
		///                           1-普通用户
		///                           2-开发用户
		///                           3-线上测试用户（调用第三方扣减）
		///                           4-线上测试用户（不调用第三方扣减）
		///                           5-仿真用户
		///                           6-接口联调用户
		///                           9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int PUserKind { get; set; }
		/// <summary>
		/// 邀请人奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long Bonus { get; set; }
		/// <summary>
		/// 邀请人获得奖励金额需要完成的流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 9)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 被邀请人
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 10)]
		public string UserID { get; set; }
		/// <summary>
		/// 被邀请人用户类型
		///                           0-未知
		///                           1-普通用户
		///                           2-开发用户
		///                           3-线上测试用户（调用第三方扣减）
		///                           4-线上测试用户（不调用第三方扣减）
		///                           5-仿真用户
		///                           6-接口联调用户
		///                           9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int? UserKind { get; set; }
		/// <summary>
		/// 被邀请人注册时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime? RegistDate { get; set; }
		/// <summary>
		/// 被邀请人首次充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long? FirstPayAmount { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 有效被邀请人用户数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int? ValidUserCount { get; set; }
		/// <summary>
		/// 月份
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 16)]
		public DateTime? MonthDate { get; set; }
		/// <summary>
		/// sb_bank_order.OrderID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 17)]
		public string OrderID { get; set; }
		/// <summary>
		/// 领取状态
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 18)]
		public bool ReceiveStatus { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_invite100011_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_invite100011_detailEO MapDataReader(IDataReader reader)
		{
		    Sa_invite100011_detailEO ret = new Sa_invite100011_detailEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.RewardType = reader.ToInt32("RewardType");
			ret.PUserID = reader.ToString("PUserID");
			ret.PUserKind = reader.ToInt32("PUserKind");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.UserID = reader.ToString("UserID");
			ret.UserKind = reader.ToInt32N("UserKind");
			ret.RegistDate = reader.ToDateTimeN("RegistDate");
			ret.FirstPayAmount = reader.ToInt64N("FirstPayAmount");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.ValidUserCount = reader.ToInt32N("ValidUserCount");
			ret.MonthDate = reader.ToDateTimeN("MonthDate");
			ret.OrderID = reader.ToString("OrderID");
			ret.ReceiveStatus = reader.ToBoolean("ReceiveStatus");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 邀请人首充奖励明细
	/// 【表 sa_invite100011_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_invite100011_detailMO : MySqlTableMO<Sa_invite100011_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_invite100011_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_invite100011_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_invite100011_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_invite100011_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_invite100011_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_invite100011_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_invite100011_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `OperatorID`, `CountryId`, `CurrencyID`, `RewardType`, `PUserID`, `PUserKind`, `Bonus`, `FlowMultip`, `UserID`, `UserKind`, `RegistDate`, `FirstPayAmount`, `RecDate`, `ValidUserCount`, `MonthDate`, `OrderID`, `ReceiveStatus`) VALUE (@DetailID, @OperatorID, @CountryId, @CurrencyID, @RewardType, @PUserID, @PUserKind, @Bonus, @FlowMultip, @UserID, @UserKind, @RegistDate, @FirstPayAmount, @RecDate, @ValidUserCount, @MonthDate, @OrderID, @ReceiveStatus);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserKind", item.PUserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind.HasValue ? item.UserKind.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@FirstPayAmount", item.FirstPayAmount.HasValue ? item.FirstPayAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ValidUserCount", item.ValidUserCount.HasValue ? item.ValidUserCount.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MonthDate", item.MonthDate.HasValue ? item.MonthDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@OrderID", item.OrderID != null ? item.OrderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<Sa_invite100011_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_invite100011_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_invite100011_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `OperatorID`, `CountryId`, `CurrencyID`, `RewardType`, `PUserID`, `PUserKind`, `Bonus`, `FlowMultip`, `UserID`, `UserKind`, `RegistDate`, `FirstPayAmount`, `RecDate`, `ValidUserCount`, `MonthDate`, `OrderID`, `ReceiveStatus`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.RewardType},'{item.PUserID}',{item.PUserKind},{item.Bonus},{item.FlowMultip},'{item.UserID}',{item.UserKind?.ToString()??null},'{item.RegistDate?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.FirstPayAmount?.ToString()??null},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.ValidUserCount?.ToString()??null},'{item.MonthDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OrderID}',{item.ReceiveStatus}),");
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
		/// /// <param name = "detailID">主键guid</param>
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
		public int Remove(Sa_invite100011_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_invite100011_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DetailID, tm_);
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
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
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
		#region RemoveByPUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserID(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserIDData(string pUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserID` = @PUserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUserID
		#region RemoveByPUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserKind(int pUserKind, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserKindData(pUserKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserKindAsync(int pUserKind, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserKindData(pUserKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserKindData(int pUserKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserKind` = @PUserKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByPUserKind
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
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
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
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
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserKind(int? userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserKindAsync(int? userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserKindData(int? userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userKind.HasValue ? "`UserKind` = @UserKind" : "`UserKind` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userKind.HasValue)
				paras_.Add(Database.CreateInParameter("@UserKind", userKind.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserKind
		#region RemoveByRegistDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
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
		#region RemoveByFirstPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPayAmount(long? firstPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayAmountData(firstPayAmount.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayAmountAsync(long? firstPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayAmountData(firstPayAmount.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayAmountData(long? firstPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (firstPayAmount.HasValue ? "`FirstPayAmount` = @FirstPayAmount" : "`FirstPayAmount` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (firstPayAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount.Value, MySqlDbType.Int64));
		}
		#endregion // RemoveByFirstPayAmount
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
		#region RemoveByValidUserCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValidUserCount(int? validUserCount, TransactionManager tm_ = null)
		{
			RepairRemoveByValidUserCountData(validUserCount.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValidUserCountAsync(int? validUserCount, TransactionManager tm_ = null)
		{
			RepairRemoveByValidUserCountData(validUserCount.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValidUserCountData(int? validUserCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (validUserCount.HasValue ? "`ValidUserCount` = @ValidUserCount" : "`ValidUserCount` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (validUserCount.HasValue)
				paras_.Add(Database.CreateInParameter("@ValidUserCount", validUserCount.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByValidUserCount
		#region RemoveByMonthDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMonthDate(DateTime? monthDate, TransactionManager tm_ = null)
		{
			RepairRemoveByMonthDateData(monthDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMonthDateAsync(DateTime? monthDate, TransactionManager tm_ = null)
		{
			RepairRemoveByMonthDateData(monthDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMonthDateData(DateTime? monthDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (monthDate.HasValue ? "`MonthDate` = @MonthDate" : "`MonthDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (monthDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MonthDate", monthDate.Value, MySqlDbType.Date));
		}
		#endregion // RemoveByMonthDate
		#region RemoveByOrderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderID(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderIDData(string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOrderID
		#region RemoveByReceiveStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
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
		public int Put(Sa_invite100011_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_invite100011_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_invite100011_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `RewardType` = @RewardType, `PUserID` = @PUserID, `PUserKind` = @PUserKind, `Bonus` = @Bonus, `FlowMultip` = @FlowMultip, `UserID` = @UserID, `UserKind` = @UserKind, `RegistDate` = @RegistDate, `FirstPayAmount` = @FirstPayAmount, `ValidUserCount` = @ValidUserCount, `MonthDate` = @MonthDate, `OrderID` = @OrderID, `ReceiveStatus` = @ReceiveStatus WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserKind", item.PUserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind.HasValue ? item.UserKind.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@FirstPayAmount", item.FirstPayAmount.HasValue ? item.FirstPayAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@ValidUserCount", item.ValidUserCount.HasValue ? item.ValidUserCount.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MonthDate", item.MonthDate.HasValue ? item.MonthDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@OrderID", item.OrderID != null ? item.OrderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_invite100011_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_invite100011_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "detailID">主键guid</param>
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
		/// /// <param name = "detailID">主键guid</param>
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
		/// /// <param name = "detailID">主键guid</param>
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string detailID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(detailID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string detailID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(detailID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string detailID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		/// /// <param name = "detailID">主键guid</param>
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
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
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
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
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
		#region PutPUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserIDByPK(string detailID, string pUserID, TransactionManager tm_ = null)
		{
			RepairPutPUserIDByPKData(detailID, pUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPUserIDByPKAsync(string detailID, string pUserID, TransactionManager tm_ = null)
		{
			RepairPutPUserIDByPKData(detailID, pUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPUserIDByPKData(string detailID, string pUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserID
		#region PutPUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserKindByPK(string detailID, int pUserKind, TransactionManager tm_ = null)
		{
			RepairPutPUserKindByPKData(detailID, pUserKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPUserKindByPKAsync(string detailID, int pUserKind, TransactionManager tm_ = null)
		{
			RepairPutPUserKindByPKData(detailID, pUserKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPUserKindByPKData(string detailID, int pUserKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserKind` = @PUserKind  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserKind(int pUserKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserKind` = @PUserKind";
			var parameter_ = Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserKindAsync(int pUserKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserKind` = @PUserKind";
			var parameter_ = Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserKind
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "bonus">邀请人奖励金额</param>
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
		/// /// <param name = "bonus">邀请人奖励金额</param>
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
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string detailID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string detailID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string detailID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
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
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "userID">被邀请人</param>
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
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string detailID, int? userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(detailID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string detailID, int? userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(detailID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string detailID, int? userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind.HasValue ? userKind.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKind(int? userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind.HasValue ? userKind.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserKindAsync(int? userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind.HasValue ? userKind.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserKind
		#region PutRegistDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDateByPK(string detailID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(detailID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegistDateByPKAsync(string detailID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(detailID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegistDateByPKData(string detailID, DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
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
		#region PutFirstPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayAmountByPK(string detailID, long? firstPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstPayAmountByPKData(detailID, firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayAmountByPKAsync(string detailID, long? firstPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstPayAmountByPKData(detailID, firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayAmountByPKData(string detailID, long? firstPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPayAmount", firstPayAmount.HasValue ? firstPayAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayAmount(long? firstPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstPayAmount", firstPayAmount.HasValue ? firstPayAmount.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayAmountAsync(long? firstPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstPayAmount", firstPayAmount.HasValue ? firstPayAmount.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPayAmount
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		#region PutValidUserCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValidUserCountByPK(string detailID, int? validUserCount, TransactionManager tm_ = null)
		{
			RepairPutValidUserCountByPKData(detailID, validUserCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValidUserCountByPKAsync(string detailID, int? validUserCount, TransactionManager tm_ = null)
		{
			RepairPutValidUserCountByPKData(detailID, validUserCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValidUserCountByPKData(string detailID, int? validUserCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ValidUserCount` = @ValidUserCount  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ValidUserCount", validUserCount.HasValue ? validUserCount.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValidUserCount(int? validUserCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ValidUserCount` = @ValidUserCount";
			var parameter_ = Database.CreateInParameter("@ValidUserCount", validUserCount.HasValue ? validUserCount.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValidUserCountAsync(int? validUserCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ValidUserCount` = @ValidUserCount";
			var parameter_ = Database.CreateInParameter("@ValidUserCount", validUserCount.HasValue ? validUserCount.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValidUserCount
		#region PutMonthDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "monthDate">月份</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMonthDateByPK(string detailID, DateTime? monthDate, TransactionManager tm_ = null)
		{
			RepairPutMonthDateByPKData(detailID, monthDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMonthDateByPKAsync(string detailID, DateTime? monthDate, TransactionManager tm_ = null)
		{
			RepairPutMonthDateByPKData(detailID, monthDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMonthDateByPKData(string detailID, DateTime? monthDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MonthDate` = @MonthDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MonthDate", monthDate.HasValue ? monthDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMonthDate(DateTime? monthDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MonthDate` = @MonthDate";
			var parameter_ = Database.CreateInParameter("@MonthDate", monthDate.HasValue ? monthDate.Value : (object)DBNull.Value, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMonthDateAsync(DateTime? monthDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MonthDate` = @MonthDate";
			var parameter_ = Database.CreateInParameter("@MonthDate", monthDate.HasValue ? monthDate.Value : (object)DBNull.Value, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMonthDate
		#region PutOrderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderIDByPK(string detailID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(detailID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderIDByPKAsync(string detailID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(detailID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderIDByPKData(string detailID, string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderID(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderID
		#region PutReceiveStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveStatusByPK(string detailID, bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(detailID, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReceiveStatusByPKAsync(string detailID, bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(detailID, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReceiveStatusByPKData(string detailID, bool receiveStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_invite100011_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sa_invite100011_detailEO item, TransactionManager tm = null)
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
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_invite100011_detailEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<Sa_invite100011_detailEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
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
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		/// 按主键查询 PUserID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUserIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetPUserIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PUserKind（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPUserKindByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PUserKind`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetPUserKindByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PUserKind`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetUserKindByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`UserKind`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int?> GetUserKindByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`UserKind`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegistDate（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRegistDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RegistDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime?> GetRegistDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RegistDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPayAmount（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long? GetFirstPayAmountByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long?)GetScalar("`FirstPayAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long?> GetFirstPayAmountByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long?)await GetScalarAsync("`FirstPayAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
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
		
		/// <summary>
		/// 按主键查询 ValidUserCount（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetValidUserCountByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`ValidUserCount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int?> GetValidUserCountByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`ValidUserCount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MonthDate（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetMonthDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`MonthDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime?> GetMonthDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`MonthDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOrderIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OrderID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetOrderIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OrderID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReceiveStatus（字段）
		/// </summary>
		/// /// <param name = "detailID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetReceiveStatusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`ReceiveStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<bool> GetReceiveStatusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`ReceiveStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_invite100011_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_invite100011_detailEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_invite100011_detailEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">0-预留值1-首充奖励2-邀请人数奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByPUserID
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID)
		{
			return GetByPUserID(pUserID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, int top_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, int top_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, int top_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, int top_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, string sort_)
		{
			return GetByPUserID(pUserID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, string sort_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, string sort_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, string sort_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserID(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserIDAsync(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByPUserID
		#region GetByPUserKind
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind)
		{
			return GetByPUserKind(pUserKind, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind)
		{
			return await GetByPUserKindAsync(pUserKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, TransactionManager tm_)
		{
			return GetByPUserKind(pUserKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, TransactionManager tm_)
		{
			return await GetByPUserKindAsync(pUserKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, int top_)
		{
			return GetByPUserKind(pUserKind, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, int top_)
		{
			return await GetByPUserKindAsync(pUserKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, int top_, TransactionManager tm_)
		{
			return GetByPUserKind(pUserKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, int top_, TransactionManager tm_)
		{
			return await GetByPUserKindAsync(pUserKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, string sort_)
		{
			return GetByPUserKind(pUserKind, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, string sort_)
		{
			return await GetByPUserKindAsync(pUserKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, string sort_, TransactionManager tm_)
		{
			return GetByPUserKind(pUserKind, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, string sort_, TransactionManager tm_)
		{
			return await GetByPUserKindAsync(pUserKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserKind（字段） 查询
		/// </summary>
		/// /// <param name = "pUserKind">邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByPUserKind(int pUserKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserKind` = @PUserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByPUserKindAsync(int pUserKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserKind` = @PUserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserKind", pUserKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByPUserKind
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">邀请人奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">邀请人获得奖励金额需要完成的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">被邀请人用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByUserKind(int? userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userKind.HasValue ? "`UserKind` = @UserKind" : "`UserKind` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userKind.HasValue)
				paras_.Add(Database.CreateInParameter("@UserKind", userKind.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByUserKindAsync(int? userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userKind.HasValue ? "`UserKind` = @UserKind" : "`UserKind` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userKind.HasValue)
				paras_.Add(Database.CreateInParameter("@UserKind", userKind.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByRegistDate
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate)
		{
			return GetByRegistDate(registDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, int top_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, int top_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, string sort_)
		{
			return GetByRegistDate(registDate, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, string sort_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">被邀请人注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRegistDate(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRegistDateAsync(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByRegistDate
		#region GetByFirstPayAmount
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, int top_)
		{
			return GetByFirstPayAmount(firstPayAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, int top_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, int top_, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, string sort_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, string sort_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">被邀请人首次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByFirstPayAmount(long? firstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstPayAmount.HasValue ? "`FirstPayAmount` = @FirstPayAmount" : "`FirstPayAmount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstPayAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount.Value, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByFirstPayAmountAsync(long? firstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstPayAmount.HasValue ? "`FirstPayAmount` = @FirstPayAmount" : "`FirstPayAmount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstPayAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount.Value, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByFirstPayAmount
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_invite100011_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByValidUserCount
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount)
		{
			return GetByValidUserCount(validUserCount, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount)
		{
			return await GetByValidUserCountAsync(validUserCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, TransactionManager tm_)
		{
			return GetByValidUserCount(validUserCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, TransactionManager tm_)
		{
			return await GetByValidUserCountAsync(validUserCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, int top_)
		{
			return GetByValidUserCount(validUserCount, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, int top_)
		{
			return await GetByValidUserCountAsync(validUserCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, int top_, TransactionManager tm_)
		{
			return GetByValidUserCount(validUserCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, int top_, TransactionManager tm_)
		{
			return await GetByValidUserCountAsync(validUserCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, string sort_)
		{
			return GetByValidUserCount(validUserCount, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, string sort_)
		{
			return await GetByValidUserCountAsync(validUserCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, string sort_, TransactionManager tm_)
		{
			return GetByValidUserCount(validUserCount, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, string sort_, TransactionManager tm_)
		{
			return await GetByValidUserCountAsync(validUserCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ValidUserCount（字段） 查询
		/// </summary>
		/// /// <param name = "validUserCount">有效被邀请人用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByValidUserCount(int? validUserCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(validUserCount.HasValue ? "`ValidUserCount` = @ValidUserCount" : "`ValidUserCount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (validUserCount.HasValue)
				paras_.Add(Database.CreateInParameter("@ValidUserCount", validUserCount.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByValidUserCountAsync(int? validUserCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(validUserCount.HasValue ? "`ValidUserCount` = @ValidUserCount" : "`ValidUserCount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (validUserCount.HasValue)
				paras_.Add(Database.CreateInParameter("@ValidUserCount", validUserCount.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByValidUserCount
		#region GetByMonthDate
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate)
		{
			return GetByMonthDate(monthDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate)
		{
			return await GetByMonthDateAsync(monthDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, TransactionManager tm_)
		{
			return GetByMonthDate(monthDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, TransactionManager tm_)
		{
			return await GetByMonthDateAsync(monthDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, int top_)
		{
			return GetByMonthDate(monthDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, int top_)
		{
			return await GetByMonthDateAsync(monthDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, int top_, TransactionManager tm_)
		{
			return GetByMonthDate(monthDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, int top_, TransactionManager tm_)
		{
			return await GetByMonthDateAsync(monthDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, string sort_)
		{
			return GetByMonthDate(monthDate, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, string sort_)
		{
			return await GetByMonthDateAsync(monthDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, string sort_, TransactionManager tm_)
		{
			return GetByMonthDate(monthDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, string sort_, TransactionManager tm_)
		{
			return await GetByMonthDateAsync(monthDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MonthDate（字段） 查询
		/// </summary>
		/// /// <param name = "monthDate">月份</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByMonthDate(DateTime? monthDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(monthDate.HasValue ? "`MonthDate` = @MonthDate" : "`MonthDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (monthDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MonthDate", monthDate.Value, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByMonthDateAsync(DateTime? monthDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(monthDate.HasValue ? "`MonthDate` = @MonthDate" : "`MonthDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (monthDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MonthDate", monthDate.Value, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByMonthDate
		#region GetByOrderID
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID)
		{
			return GetByOrderID(orderID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, int top_)
		{
			return GetByOrderID(orderID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, int top_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, int top_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, int top_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, string sort_)
		{
			return GetByOrderID(orderID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, string sort_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, string sort_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, string sort_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">sb_bank_order.OrderID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByOrderID(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByOrderIDAsync(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByOrderID
		#region GetByReceiveStatus
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, int top_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, int top_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, string sort_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, null);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, string sort_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, string sort_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, string sort_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">领取状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100011_detailEO> GetByReceiveStatus(bool receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		public async Task<List<Sa_invite100011_detailEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100011_detailEO.MapDataReader);
		}
		#endregion // GetByReceiveStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
