/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:51
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
	/// 用户银行信息表
	/// 【表 l_user_bank_info 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_user_bank_infoEO : IRowMapper<L_user_bank_infoEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_user_bank_infoEO()
		{
			this.BankType = 1;
			this.LastUsing = 0;
			this.RecDate = DateTime.Now;
			this.ModifyDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalUserBankID;
		/// <summary>
		/// 【数据库中的原始主键 UserBankID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserBankID
		{
			get { return _originalUserBankID; }
			set { HasOriginal = true; _originalUserBankID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserBankID", UserBankID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 唯一编码GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserBankID { get; set; }
		/// <summary>
		/// 用户编码
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 银行卡类型1-Visa;2-Spei
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int BankType { get; set; }
		/// <summary>
		/// 银行编码(目前只有Spei在用)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 6)]
		public string BankCode { get; set; }
		/// <summary>
		/// 银行名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string BankName { get; set; }
		/// <summary>
		/// 银行卡号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string CardNo { get; set; }
		/// <summary>
		/// 用户全名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 9)]
		public string UserName { get; set; }
		/// <summary>
		/// 用户名
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string FirstName { get; set; }
		/// <summary>
		/// 用户姓
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 11)]
		public string LastName { get; set; }
		/// <summary>
		/// 过期时间
		/// 【字段 varchar(10)】
		/// </summary>
		[DataMember(Order = 12)]
		public string ExpiryDate { get; set; }
		/// <summary>
		/// CVV
		/// 【字段 varchar(10)】
		/// </summary>
		[DataMember(Order = 13)]
		public string CVV { get; set; }
		/// <summary>
		/// 电话号码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 14)]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 邮箱
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 15)]
		public string Email { get; set; }
		/// <summary>
		/// 州
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 16)]
		public string State { get; set; }
		/// <summary>
		/// 城市
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 17)]
		public string City { get; set; }
		/// <summary>
		/// 街道
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 18)]
		public string Street { get; set; }
		/// <summary>
		/// 邮编
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 19)]
		public string PostalCode { get; set; }
		/// <summary>
		/// 最后充值、提现使用的卡
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int LastUsing { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 21)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 更新时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 22)]
		public DateTime ModifyDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_user_bank_infoEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_user_bank_infoEO MapDataReader(IDataReader reader)
		{
		    L_user_bank_infoEO ret = new L_user_bank_infoEO();
			ret.UserBankID = reader.ToString("UserBankID");
			ret.OriginalUserBankID = ret.UserBankID;
			ret.UserID = reader.ToString("UserID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.BankType = reader.ToInt32("BankType");
			ret.BankCode = reader.ToString("BankCode");
			ret.BankName = reader.ToString("BankName");
			ret.CardNo = reader.ToString("CardNo");
			ret.UserName = reader.ToString("UserName");
			ret.FirstName = reader.ToString("FirstName");
			ret.LastName = reader.ToString("LastName");
			ret.ExpiryDate = reader.ToString("ExpiryDate");
			ret.CVV = reader.ToString("CVV");
			ret.PhoneNumber = reader.ToString("PhoneNumber");
			ret.Email = reader.ToString("Email");
			ret.State = reader.ToString("State");
			ret.City = reader.ToString("City");
			ret.Street = reader.ToString("Street");
			ret.PostalCode = reader.ToString("PostalCode");
			ret.LastUsing = reader.ToInt32("LastUsing");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.ModifyDate = reader.ToDateTime("ModifyDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户银行信息表
	/// 【表 l_user_bank_info 的操作类】
	/// </summary>
	[Obsolete]
	public class L_user_bank_infoMO : MySqlTableMO<L_user_bank_infoEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_user_bank_info`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_user_bank_infoMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_user_bank_infoMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_user_bank_infoMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_user_bank_infoEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_user_bank_infoEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_user_bank_infoEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserBankID`, `UserID`, `CountryID`, `CurrencyID`, `BankType`, `BankCode`, `BankName`, `CardNo`, `UserName`, `FirstName`, `LastName`, `ExpiryDate`, `CVV`, `PhoneNumber`, `Email`, `State`, `City`, `Street`, `PostalCode`, `LastUsing`, `RecDate`, `ModifyDate`) VALUE (@UserBankID, @UserID, @CountryID, @CurrencyID, @BankType, @BankCode, @BankName, @CardNo, @UserName, @FirstName, @LastName, @ExpiryDate, @CVV, @PhoneNumber, @Email, @State, @City, @Street, @PostalCode, @LastUsing, @RecDate, @ModifyDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", item.UserBankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankType", item.BankType, MySqlDbType.Int32),
				Database.CreateInParameter("@BankCode", item.BankCode != null ? item.BankCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankName", item.BankName != null ? item.BankName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CardNo", item.CardNo != null ? item.CardNo : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserName", item.UserName != null ? item.UserName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FirstName", item.FirstName != null ? item.FirstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastName", item.LastName != null ? item.LastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExpiryDate", item.ExpiryDate != null ? item.ExpiryDate : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CVV", item.CVV != null ? item.CVV : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PhoneNumber", item.PhoneNumber != null ? item.PhoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@State", item.State != null ? item.State : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@City", item.City != null ? item.City : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Street", item.Street != null ? item.Street : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PostalCode", item.PostalCode != null ? item.PostalCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastUsing", item.LastUsing, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ModifyDate", item.ModifyDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_user_bank_infoEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_user_bank_infoEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_user_bank_infoEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserBankID`, `UserID`, `CountryID`, `CurrencyID`, `BankType`, `BankCode`, `BankName`, `CardNo`, `UserName`, `FirstName`, `LastName`, `ExpiryDate`, `CVV`, `PhoneNumber`, `Email`, `State`, `City`, `Street`, `PostalCode`, `LastUsing`, `RecDate`, `ModifyDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserBankID}','{item.UserID}','{item.CountryID}','{item.CurrencyID}',{item.BankType},'{item.BankCode}','{item.BankName}','{item.CardNo}','{item.UserName}','{item.FirstName}','{item.LastName}','{item.ExpiryDate}','{item.CVV}','{item.PhoneNumber}','{item.Email}','{item.State}','{item.City}','{item.Street}','{item.PostalCode}',{item.LastUsing},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ModifyDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userBankID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userBankID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userBankID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userBankID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_user_bank_infoEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserBankID, tm_);
		}
		public async Task<int> RemoveAsync(L_user_bank_infoEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserBankID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
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
		#region RemoveByBankType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankType(int bankType, TransactionManager tm_ = null)
		{
			RepairRemoveByBankTypeData(bankType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankTypeAsync(int bankType, TransactionManager tm_ = null)
		{
			RepairRemoveByBankTypeData(bankType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankTypeData(int bankType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BankType` = @BankType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32));
		}
		#endregion // RemoveByBankType
		#region RemoveByBankCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankCode(string bankCode, TransactionManager tm_ = null)
		{
			RepairRemoveByBankCodeData(bankCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankCodeAsync(string bankCode, TransactionManager tm_ = null)
		{
			RepairRemoveByBankCodeData(bankCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankCodeData(string bankCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bankCode != null ? "`BankCode` = @BankCode" : "`BankCode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bankCode != null)
				paras_.Add(Database.CreateInParameter("@BankCode", bankCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankCode
		#region RemoveByBankName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankName(string bankName, TransactionManager tm_ = null)
		{
			RepairRemoveByBankNameData(bankName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankNameAsync(string bankName, TransactionManager tm_ = null)
		{
			RepairRemoveByBankNameData(bankName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankNameData(string bankName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bankName != null ? "`BankName` = @BankName" : "`BankName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bankName != null)
				paras_.Add(Database.CreateInParameter("@BankName", bankName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankName
		#region RemoveByCardNo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCardNo(string cardNo, TransactionManager tm_ = null)
		{
			RepairRemoveByCardNoData(cardNo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCardNoAsync(string cardNo, TransactionManager tm_ = null)
		{
			RepairRemoveByCardNoData(cardNo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCardNoData(string cardNo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cardNo != null ? "`CardNo` = @CardNo" : "`CardNo` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cardNo != null)
				paras_.Add(Database.CreateInParameter("@CardNo", cardNo, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCardNo
		#region RemoveByUserName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserName(string userName, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNameData(userName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserNameAsync(string userName, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNameData(userName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserNameData(string userName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userName != null ? "`UserName` = @UserName" : "`UserName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userName != null)
				paras_.Add(Database.CreateInParameter("@UserName", userName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserName
		#region RemoveByFirstName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstName(string firstName, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstNameData(firstName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstNameAsync(string firstName, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstNameData(firstName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstNameData(string firstName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (firstName != null ? "`FirstName` = @FirstName" : "`FirstName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (firstName != null)
				paras_.Add(Database.CreateInParameter("@FirstName", firstName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFirstName
		#region RemoveByLastName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastName(string lastName, TransactionManager tm_ = null)
		{
			RepairRemoveByLastNameData(lastName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastNameAsync(string lastName, TransactionManager tm_ = null)
		{
			RepairRemoveByLastNameData(lastName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastNameData(string lastName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastName != null ? "`LastName` = @LastName" : "`LastName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastName != null)
				paras_.Add(Database.CreateInParameter("@LastName", lastName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLastName
		#region RemoveByExpiryDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByExpiryDate(string expiryDate, TransactionManager tm_ = null)
		{
			RepairRemoveByExpiryDateData(expiryDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByExpiryDateAsync(string expiryDate, TransactionManager tm_ = null)
		{
			RepairRemoveByExpiryDateData(expiryDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByExpiryDateData(string expiryDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (expiryDate != null ? "`ExpiryDate` = @ExpiryDate" : "`ExpiryDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (expiryDate != null)
				paras_.Add(Database.CreateInParameter("@ExpiryDate", expiryDate, MySqlDbType.VarChar));
		}
		#endregion // RemoveByExpiryDate
		#region RemoveByCVV
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCVV(string cVV, TransactionManager tm_ = null)
		{
			RepairRemoveByCVVData(cVV, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCVVAsync(string cVV, TransactionManager tm_ = null)
		{
			RepairRemoveByCVVData(cVV, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCVVData(string cVV, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cVV != null ? "`CVV` = @CVV" : "`CVV` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cVV != null)
				paras_.Add(Database.CreateInParameter("@CVV", cVV, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCVV
		#region RemoveByPhoneNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPhoneNumber(string phoneNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByPhoneNumberData(phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPhoneNumberAsync(string phoneNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByPhoneNumberData(phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPhoneNumberData(string phoneNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (phoneNumber != null ? "`PhoneNumber` = @PhoneNumber" : "`PhoneNumber` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (phoneNumber != null)
				paras_.Add(Database.CreateInParameter("@PhoneNumber", phoneNumber, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPhoneNumber
		#region RemoveByEmail
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEmail(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEmailAsync(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEmailData(string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (email != null ? "`Email` = @Email" : "`Email` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
		}
		#endregion // RemoveByEmail
		#region RemoveByState
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByState(string state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStateAsync(string state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStateData(string state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (state != null ? "`State` = @State" : "`State` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (state != null)
				paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.VarChar));
		}
		#endregion // RemoveByState
		#region RemoveByCity
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCity(string city, TransactionManager tm_ = null)
		{
			RepairRemoveByCityData(city, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCityAsync(string city, TransactionManager tm_ = null)
		{
			RepairRemoveByCityData(city, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCityData(string city, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (city != null ? "`City` = @City" : "`City` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (city != null)
				paras_.Add(Database.CreateInParameter("@City", city, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCity
		#region RemoveByStreet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStreet(string street, TransactionManager tm_ = null)
		{
			RepairRemoveByStreetData(street, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStreetAsync(string street, TransactionManager tm_ = null)
		{
			RepairRemoveByStreetData(street, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStreetData(string street, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (street != null ? "`Street` = @Street" : "`Street` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (street != null)
				paras_.Add(Database.CreateInParameter("@Street", street, MySqlDbType.VarChar));
		}
		#endregion // RemoveByStreet
		#region RemoveByPostalCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPostalCode(string postalCode, TransactionManager tm_ = null)
		{
			RepairRemoveByPostalCodeData(postalCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPostalCodeAsync(string postalCode, TransactionManager tm_ = null)
		{
			RepairRemoveByPostalCodeData(postalCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPostalCodeData(string postalCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (postalCode != null ? "`PostalCode` = @PostalCode" : "`PostalCode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (postalCode != null)
				paras_.Add(Database.CreateInParameter("@PostalCode", postalCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPostalCode
		#region RemoveByLastUsing
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastUsing(int lastUsing, TransactionManager tm_ = null)
		{
			RepairRemoveByLastUsingData(lastUsing, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastUsingAsync(int lastUsing, TransactionManager tm_ = null)
		{
			RepairRemoveByLastUsingData(lastUsing, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastUsingData(int lastUsing, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastUsing` = @LastUsing";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32));
		}
		#endregion // RemoveByLastUsing
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
		#region RemoveByModifyDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByModifyDate(DateTime modifyDate, TransactionManager tm_ = null)
		{
			RepairRemoveByModifyDateData(modifyDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByModifyDateAsync(DateTime modifyDate, TransactionManager tm_ = null)
		{
			RepairRemoveByModifyDateData(modifyDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByModifyDateData(DateTime modifyDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ModifyDate` = @ModifyDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByModifyDate
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
		public int Put(L_user_bank_infoEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_user_bank_infoEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_user_bank_infoEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserBankID` = @UserBankID, `UserID` = @UserID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `BankType` = @BankType, `BankCode` = @BankCode, `BankName` = @BankName, `CardNo` = @CardNo, `UserName` = @UserName, `FirstName` = @FirstName, `LastName` = @LastName, `ExpiryDate` = @ExpiryDate, `CVV` = @CVV, `PhoneNumber` = @PhoneNumber, `Email` = @Email, `State` = @State, `City` = @City, `Street` = @Street, `PostalCode` = @PostalCode, `LastUsing` = @LastUsing WHERE `UserBankID` = @UserBankID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", item.UserBankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankType", item.BankType, MySqlDbType.Int32),
				Database.CreateInParameter("@BankCode", item.BankCode != null ? item.BankCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankName", item.BankName != null ? item.BankName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CardNo", item.CardNo != null ? item.CardNo : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserName", item.UserName != null ? item.UserName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FirstName", item.FirstName != null ? item.FirstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastName", item.LastName != null ? item.LastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExpiryDate", item.ExpiryDate != null ? item.ExpiryDate : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CVV", item.CVV != null ? item.CVV : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PhoneNumber", item.PhoneNumber != null ? item.PhoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@State", item.State != null ? item.State : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@City", item.City != null ? item.City : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Street", item.Street != null ? item.Street : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PostalCode", item.PostalCode != null ? item.PostalCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastUsing", item.LastUsing, MySqlDbType.Int32),
				Database.CreateInParameter("@UserBankID_Original", item.HasOriginal ? item.OriginalUserBankID : item.UserBankID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_user_bank_infoEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_user_bank_infoEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userBankID, string set_, params object[] values_)
		{
			return Put(set_, "`UserBankID` = @UserBankID", ConcatValues(values_, userBankID));
		}
		public async Task<int> PutByPKAsync(string userBankID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserBankID` = @UserBankID", ConcatValues(values_, userBankID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userBankID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserBankID` = @UserBankID", tm_, ConcatValues(values_, userBankID));
		}
		public async Task<int> PutByPKAsync(string userBankID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserBankID` = @UserBankID", tm_, ConcatValues(values_, userBankID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userBankID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserBankID` = @UserBankID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userBankID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserBankID` = @UserBankID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string userBankID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(userBankID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string userBankID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(userBankID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string userBankID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string userBankID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userBankID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string userBankID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userBankID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string userBankID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
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
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userBankID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userBankID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userBankID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userBankID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userBankID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
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
		#region PutBankType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankTypeByPK(string userBankID, int bankType, TransactionManager tm_ = null)
		{
			RepairPutBankTypeByPKData(userBankID, bankType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankTypeByPKAsync(string userBankID, int bankType, TransactionManager tm_ = null)
		{
			RepairPutBankTypeByPKData(userBankID, bankType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankTypeByPKData(string userBankID, int bankType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankType` = @BankType  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankType(int bankType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankType` = @BankType";
			var parameter_ = Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankTypeAsync(int bankType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankType` = @BankType";
			var parameter_ = Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankType
		#region PutBankCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankCodeByPK(string userBankID, string bankCode, TransactionManager tm_ = null)
		{
			RepairPutBankCodeByPKData(userBankID, bankCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankCodeByPKAsync(string userBankID, string bankCode, TransactionManager tm_ = null)
		{
			RepairPutBankCodeByPKData(userBankID, bankCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankCodeByPKData(string userBankID, string bankCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankCode` = @BankCode  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankCode", bankCode != null ? bankCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankCode(string bankCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankCode` = @BankCode";
			var parameter_ = Database.CreateInParameter("@BankCode", bankCode != null ? bankCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankCodeAsync(string bankCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankCode` = @BankCode";
			var parameter_ = Database.CreateInParameter("@BankCode", bankCode != null ? bankCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankCode
		#region PutBankName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankNameByPK(string userBankID, string bankName, TransactionManager tm_ = null)
		{
			RepairPutBankNameByPKData(userBankID, bankName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankNameByPKAsync(string userBankID, string bankName, TransactionManager tm_ = null)
		{
			RepairPutBankNameByPKData(userBankID, bankName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankNameByPKData(string userBankID, string bankName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankName` = @BankName  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankName", bankName != null ? bankName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankName(string bankName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankName` = @BankName";
			var parameter_ = Database.CreateInParameter("@BankName", bankName != null ? bankName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankNameAsync(string bankName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankName` = @BankName";
			var parameter_ = Database.CreateInParameter("@BankName", bankName != null ? bankName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankName
		#region PutCardNo
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCardNoByPK(string userBankID, string cardNo, TransactionManager tm_ = null)
		{
			RepairPutCardNoByPKData(userBankID, cardNo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCardNoByPKAsync(string userBankID, string cardNo, TransactionManager tm_ = null)
		{
			RepairPutCardNoByPKData(userBankID, cardNo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCardNoByPKData(string userBankID, string cardNo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CardNo` = @CardNo  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CardNo", cardNo != null ? cardNo : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCardNo(string cardNo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CardNo` = @CardNo";
			var parameter_ = Database.CreateInParameter("@CardNo", cardNo != null ? cardNo : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCardNoAsync(string cardNo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CardNo` = @CardNo";
			var parameter_ = Database.CreateInParameter("@CardNo", cardNo != null ? cardNo : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCardNo
		#region PutUserName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "userName">用户全名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNameByPK(string userBankID, string userName, TransactionManager tm_ = null)
		{
			RepairPutUserNameByPKData(userBankID, userName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserNameByPKAsync(string userBankID, string userName, TransactionManager tm_ = null)
		{
			RepairPutUserNameByPKData(userBankID, userName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserNameByPKData(string userBankID, string userName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserName` = @UserName  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserName", userName != null ? userName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserName(string userName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserName` = @UserName";
			var parameter_ = Database.CreateInParameter("@UserName", userName != null ? userName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserNameAsync(string userName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserName` = @UserName";
			var parameter_ = Database.CreateInParameter("@UserName", userName != null ? userName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserName
		#region PutFirstName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "firstName">用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstNameByPK(string userBankID, string firstName, TransactionManager tm_ = null)
		{
			RepairPutFirstNameByPKData(userBankID, firstName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstNameByPKAsync(string userBankID, string firstName, TransactionManager tm_ = null)
		{
			RepairPutFirstNameByPKData(userBankID, firstName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstNameByPKData(string userBankID, string firstName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstName` = @FirstName  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstName", firstName != null ? firstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstName(string firstName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstName` = @FirstName";
			var parameter_ = Database.CreateInParameter("@FirstName", firstName != null ? firstName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstNameAsync(string firstName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstName` = @FirstName";
			var parameter_ = Database.CreateInParameter("@FirstName", firstName != null ? firstName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstName
		#region PutLastName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastNameByPK(string userBankID, string lastName, TransactionManager tm_ = null)
		{
			RepairPutLastNameByPKData(userBankID, lastName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastNameByPKAsync(string userBankID, string lastName, TransactionManager tm_ = null)
		{
			RepairPutLastNameByPKData(userBankID, lastName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastNameByPKData(string userBankID, string lastName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastName` = @LastName  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastName", lastName != null ? lastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastName(string lastName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastName` = @LastName";
			var parameter_ = Database.CreateInParameter("@LastName", lastName != null ? lastName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastNameAsync(string lastName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastName` = @LastName";
			var parameter_ = Database.CreateInParameter("@LastName", lastName != null ? lastName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastName
		#region PutExpiryDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExpiryDateByPK(string userBankID, string expiryDate, TransactionManager tm_ = null)
		{
			RepairPutExpiryDateByPKData(userBankID, expiryDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutExpiryDateByPKAsync(string userBankID, string expiryDate, TransactionManager tm_ = null)
		{
			RepairPutExpiryDateByPKData(userBankID, expiryDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutExpiryDateByPKData(string userBankID, string expiryDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ExpiryDate` = @ExpiryDate  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExpiryDate", expiryDate != null ? expiryDate : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExpiryDate(string expiryDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ExpiryDate` = @ExpiryDate";
			var parameter_ = Database.CreateInParameter("@ExpiryDate", expiryDate != null ? expiryDate : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutExpiryDateAsync(string expiryDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ExpiryDate` = @ExpiryDate";
			var parameter_ = Database.CreateInParameter("@ExpiryDate", expiryDate != null ? expiryDate : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutExpiryDate
		#region PutCVV
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "cVV">CVV</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCVVByPK(string userBankID, string cVV, TransactionManager tm_ = null)
		{
			RepairPutCVVByPKData(userBankID, cVV, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCVVByPKAsync(string userBankID, string cVV, TransactionManager tm_ = null)
		{
			RepairPutCVVByPKData(userBankID, cVV, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCVVByPKData(string userBankID, string cVV, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CVV` = @CVV  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CVV", cVV != null ? cVV : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCVV(string cVV, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CVV` = @CVV";
			var parameter_ = Database.CreateInParameter("@CVV", cVV != null ? cVV : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCVVAsync(string cVV, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CVV` = @CVV";
			var parameter_ = Database.CreateInParameter("@CVV", cVV != null ? cVV : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCVV
		#region PutPhoneNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPhoneNumberByPK(string userBankID, string phoneNumber, TransactionManager tm_ = null)
		{
			RepairPutPhoneNumberByPKData(userBankID, phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPhoneNumberByPKAsync(string userBankID, string phoneNumber, TransactionManager tm_ = null)
		{
			RepairPutPhoneNumberByPKData(userBankID, phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPhoneNumberByPKData(string userBankID, string phoneNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PhoneNumber` = @PhoneNumber  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PhoneNumber", phoneNumber != null ? phoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPhoneNumber(string phoneNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PhoneNumber` = @PhoneNumber";
			var parameter_ = Database.CreateInParameter("@PhoneNumber", phoneNumber != null ? phoneNumber : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPhoneNumberAsync(string phoneNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PhoneNumber` = @PhoneNumber";
			var parameter_ = Database.CreateInParameter("@PhoneNumber", phoneNumber != null ? phoneNumber : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPhoneNumber
		#region PutEmail
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmailByPK(string userBankID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userBankID, email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEmailByPKAsync(string userBankID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userBankID, email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEmailByPKData(string userBankID, string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Email` = @Email  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmail(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEmailAsync(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEmail
		#region PutState
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "state">州</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStateByPK(string userBankID, string state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(userBankID, state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStateByPKAsync(string userBankID, string state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(userBankID, state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStateByPKData(string userBankID, string state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `State` = @State  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@State", state != null ? state : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutState(string state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state != null ? state : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStateAsync(string state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state != null ? state : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutState
		#region PutCity
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "city">城市</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCityByPK(string userBankID, string city, TransactionManager tm_ = null)
		{
			RepairPutCityByPKData(userBankID, city, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCityByPKAsync(string userBankID, string city, TransactionManager tm_ = null)
		{
			RepairPutCityByPKData(userBankID, city, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCityByPKData(string userBankID, string city, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `City` = @City  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@City", city != null ? city : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCity(string city, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `City` = @City";
			var parameter_ = Database.CreateInParameter("@City", city != null ? city : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCityAsync(string city, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `City` = @City";
			var parameter_ = Database.CreateInParameter("@City", city != null ? city : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCity
		#region PutStreet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "street">街道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStreetByPK(string userBankID, string street, TransactionManager tm_ = null)
		{
			RepairPutStreetByPKData(userBankID, street, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStreetByPKAsync(string userBankID, string street, TransactionManager tm_ = null)
		{
			RepairPutStreetByPKData(userBankID, street, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStreetByPKData(string userBankID, string street, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Street` = @Street  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Street", street != null ? street : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStreet(string street, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Street` = @Street";
			var parameter_ = Database.CreateInParameter("@Street", street != null ? street : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStreetAsync(string street, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Street` = @Street";
			var parameter_ = Database.CreateInParameter("@Street", street != null ? street : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStreet
		#region PutPostalCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPostalCodeByPK(string userBankID, string postalCode, TransactionManager tm_ = null)
		{
			RepairPutPostalCodeByPKData(userBankID, postalCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPostalCodeByPKAsync(string userBankID, string postalCode, TransactionManager tm_ = null)
		{
			RepairPutPostalCodeByPKData(userBankID, postalCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPostalCodeByPKData(string userBankID, string postalCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PostalCode` = @PostalCode  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PostalCode", postalCode != null ? postalCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPostalCode(string postalCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PostalCode` = @PostalCode";
			var parameter_ = Database.CreateInParameter("@PostalCode", postalCode != null ? postalCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPostalCodeAsync(string postalCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PostalCode` = @PostalCode";
			var parameter_ = Database.CreateInParameter("@PostalCode", postalCode != null ? postalCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPostalCode
		#region PutLastUsing
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastUsingByPK(string userBankID, int lastUsing, TransactionManager tm_ = null)
		{
			RepairPutLastUsingByPKData(userBankID, lastUsing, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastUsingByPKAsync(string userBankID, int lastUsing, TransactionManager tm_ = null)
		{
			RepairPutLastUsingByPKData(userBankID, lastUsing, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastUsingByPKData(string userBankID, int lastUsing, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastUsing` = @LastUsing  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastUsing(int lastUsing, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastUsing` = @LastUsing";
			var parameter_ = Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastUsingAsync(int lastUsing, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastUsing` = @LastUsing";
			var parameter_ = Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastUsing
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userBankID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userBankID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userBankID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userBankID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userBankID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
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
		#region PutModifyDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutModifyDateByPK(string userBankID, DateTime modifyDate, TransactionManager tm_ = null)
		{
			RepairPutModifyDateByPKData(userBankID, modifyDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutModifyDateByPKAsync(string userBankID, DateTime modifyDate, TransactionManager tm_ = null)
		{
			RepairPutModifyDateByPKData(userBankID, modifyDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutModifyDateByPKData(string userBankID, DateTime modifyDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ModifyDate` = @ModifyDate  WHERE `UserBankID` = @UserBankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutModifyDate(DateTime modifyDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ModifyDate` = @ModifyDate";
			var parameter_ = Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutModifyDateAsync(DateTime modifyDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ModifyDate` = @ModifyDate";
			var parameter_ = Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutModifyDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_user_bank_infoEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserBankID) == null)
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
		public async Task<bool> SetAsync(L_user_bank_infoEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserBankID) == null)
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
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_user_bank_infoEO GetByPK(string userBankID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userBankID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<L_user_bank_infoEO> GetByPKAsync(string userBankID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userBankID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		private void RepairGetByPKData(string userBankID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserBankID` = @UserBankID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankType（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBankTypeByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BankType`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<int> GetBankTypeByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BankType`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankCode（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankCodeByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankCode`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetBankCodeByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankCode`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankName（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankNameByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetBankNameByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CardNo（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCardNoByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CardNo`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetCardNoByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CardNo`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserName（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserNameByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetUserNameByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstName（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFirstNameByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FirstName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetFirstNameByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FirstName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastName（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLastNameByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LastName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetLastNameByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LastName`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ExpiryDate（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetExpiryDateByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ExpiryDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetExpiryDateByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ExpiryDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CVV（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCVVByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CVV`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetCVVByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CVV`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PhoneNumber（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPhoneNumberByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PhoneNumber`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetPhoneNumberByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PhoneNumber`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Email（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEmailByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Email`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetEmailByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Email`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 State（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetStateByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`State`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetStateByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`State`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 City（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCityByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`City`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetCityByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`City`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Street（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetStreetByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Street`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetStreetByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Street`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PostalCode（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPostalCodeByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PostalCode`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<string> GetPostalCodeByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PostalCode`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastUsing（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLastUsingByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LastUsing`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<int> GetLastUsingByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LastUsing`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ModifyDate（字段）
		/// </summary>
		/// /// <param name = "userBankID">唯一编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetModifyDateByPK(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`ModifyDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		public async Task<DateTime> GetModifyDateByPKAsync(string userBankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserBankID", userBankID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`ModifyDate`", "`UserBankID` = @UserBankID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<L_user_bank_infoEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<L_user_bank_infoEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByBankType
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType)
		{
			return GetByBankType(bankType, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType)
		{
			return await GetByBankTypeAsync(bankType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, TransactionManager tm_)
		{
			return GetByBankType(bankType, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, TransactionManager tm_)
		{
			return await GetByBankTypeAsync(bankType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, int top_)
		{
			return GetByBankType(bankType, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, int top_)
		{
			return await GetByBankTypeAsync(bankType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, int top_, TransactionManager tm_)
		{
			return GetByBankType(bankType, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, int top_, TransactionManager tm_)
		{
			return await GetByBankTypeAsync(bankType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, string sort_)
		{
			return GetByBankType(bankType, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, string sort_)
		{
			return await GetByBankTypeAsync(bankType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, string sort_, TransactionManager tm_)
		{
			return GetByBankType(bankType, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, string sort_, TransactionManager tm_)
		{
			return await GetByBankTypeAsync(bankType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankType（字段） 查询
		/// </summary>
		/// /// <param name = "bankType">银行卡类型1-Visa;2-Spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankType(int bankType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankType` = @BankType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankTypeAsync(int bankType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankType` = @BankType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankType", bankType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByBankType
		#region GetByBankCode
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode)
		{
			return GetByBankCode(bankCode, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode)
		{
			return await GetByBankCodeAsync(bankCode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, TransactionManager tm_)
		{
			return GetByBankCode(bankCode, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, TransactionManager tm_)
		{
			return await GetByBankCodeAsync(bankCode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, int top_)
		{
			return GetByBankCode(bankCode, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, int top_)
		{
			return await GetByBankCodeAsync(bankCode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, int top_, TransactionManager tm_)
		{
			return GetByBankCode(bankCode, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, int top_, TransactionManager tm_)
		{
			return await GetByBankCodeAsync(bankCode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, string sort_)
		{
			return GetByBankCode(bankCode, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, string sort_)
		{
			return await GetByBankCodeAsync(bankCode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, string sort_, TransactionManager tm_)
		{
			return GetByBankCode(bankCode, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, string sort_, TransactionManager tm_)
		{
			return await GetByBankCodeAsync(bankCode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankCode（字段） 查询
		/// </summary>
		/// /// <param name = "bankCode">银行编码(目前只有Spei在用)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankCode(string bankCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankCode != null ? "`BankCode` = @BankCode" : "`BankCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankCode != null)
				paras_.Add(Database.CreateInParameter("@BankCode", bankCode, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankCodeAsync(string bankCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankCode != null ? "`BankCode` = @BankCode" : "`BankCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankCode != null)
				paras_.Add(Database.CreateInParameter("@BankCode", bankCode, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByBankCode
		#region GetByBankName
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName)
		{
			return GetByBankName(bankName, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName)
		{
			return await GetByBankNameAsync(bankName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, TransactionManager tm_)
		{
			return GetByBankName(bankName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, TransactionManager tm_)
		{
			return await GetByBankNameAsync(bankName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, int top_)
		{
			return GetByBankName(bankName, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, int top_)
		{
			return await GetByBankNameAsync(bankName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, int top_, TransactionManager tm_)
		{
			return GetByBankName(bankName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, int top_, TransactionManager tm_)
		{
			return await GetByBankNameAsync(bankName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, string sort_)
		{
			return GetByBankName(bankName, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, string sort_)
		{
			return await GetByBankNameAsync(bankName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, string sort_, TransactionManager tm_)
		{
			return GetByBankName(bankName, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, string sort_, TransactionManager tm_)
		{
			return await GetByBankNameAsync(bankName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankName（字段） 查询
		/// </summary>
		/// /// <param name = "bankName">银行名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByBankName(string bankName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankName != null ? "`BankName` = @BankName" : "`BankName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankName != null)
				paras_.Add(Database.CreateInParameter("@BankName", bankName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByBankNameAsync(string bankName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankName != null ? "`BankName` = @BankName" : "`BankName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankName != null)
				paras_.Add(Database.CreateInParameter("@BankName", bankName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByBankName
		#region GetByCardNo
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo)
		{
			return GetByCardNo(cardNo, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo)
		{
			return await GetByCardNoAsync(cardNo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, TransactionManager tm_)
		{
			return GetByCardNo(cardNo, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, TransactionManager tm_)
		{
			return await GetByCardNoAsync(cardNo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, int top_)
		{
			return GetByCardNo(cardNo, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, int top_)
		{
			return await GetByCardNoAsync(cardNo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, int top_, TransactionManager tm_)
		{
			return GetByCardNo(cardNo, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, int top_, TransactionManager tm_)
		{
			return await GetByCardNoAsync(cardNo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, string sort_)
		{
			return GetByCardNo(cardNo, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, string sort_)
		{
			return await GetByCardNoAsync(cardNo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, string sort_, TransactionManager tm_)
		{
			return GetByCardNo(cardNo, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, string sort_, TransactionManager tm_)
		{
			return await GetByCardNoAsync(cardNo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CardNo（字段） 查询
		/// </summary>
		/// /// <param name = "cardNo">银行卡号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCardNo(string cardNo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cardNo != null ? "`CardNo` = @CardNo" : "`CardNo` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cardNo != null)
				paras_.Add(Database.CreateInParameter("@CardNo", cardNo, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCardNoAsync(string cardNo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cardNo != null ? "`CardNo` = @CardNo" : "`CardNo` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cardNo != null)
				paras_.Add(Database.CreateInParameter("@CardNo", cardNo, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByCardNo
		#region GetByUserName
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName)
		{
			return GetByUserName(userName, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName)
		{
			return await GetByUserNameAsync(userName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, TransactionManager tm_)
		{
			return GetByUserName(userName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, TransactionManager tm_)
		{
			return await GetByUserNameAsync(userName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, int top_)
		{
			return GetByUserName(userName, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, int top_)
		{
			return await GetByUserNameAsync(userName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, int top_, TransactionManager tm_)
		{
			return GetByUserName(userName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, int top_, TransactionManager tm_)
		{
			return await GetByUserNameAsync(userName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, string sort_)
		{
			return GetByUserName(userName, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, string sort_)
		{
			return await GetByUserNameAsync(userName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, string sort_, TransactionManager tm_)
		{
			return GetByUserName(userName, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, string sort_, TransactionManager tm_)
		{
			return await GetByUserNameAsync(userName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserName（字段） 查询
		/// </summary>
		/// /// <param name = "userName">用户全名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByUserName(string userName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userName != null ? "`UserName` = @UserName" : "`UserName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userName != null)
				paras_.Add(Database.CreateInParameter("@UserName", userName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByUserNameAsync(string userName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userName != null ? "`UserName` = @UserName" : "`UserName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userName != null)
				paras_.Add(Database.CreateInParameter("@UserName", userName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByUserName
		#region GetByFirstName
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName)
		{
			return GetByFirstName(firstName, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName)
		{
			return await GetByFirstNameAsync(firstName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, TransactionManager tm_)
		{
			return GetByFirstName(firstName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, int top_)
		{
			return GetByFirstName(firstName, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, int top_)
		{
			return await GetByFirstNameAsync(firstName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, int top_, TransactionManager tm_)
		{
			return GetByFirstName(firstName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, int top_, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, string sort_)
		{
			return GetByFirstName(firstName, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, string sort_)
		{
			return await GetByFirstNameAsync(firstName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, string sort_, TransactionManager tm_)
		{
			return GetByFirstName(firstName, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, string sort_, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByFirstName(string firstName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstName != null ? "`FirstName` = @FirstName" : "`FirstName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstName != null)
				paras_.Add(Database.CreateInParameter("@FirstName", firstName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByFirstNameAsync(string firstName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstName != null ? "`FirstName` = @FirstName" : "`FirstName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstName != null)
				paras_.Add(Database.CreateInParameter("@FirstName", firstName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByFirstName
		#region GetByLastName
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName)
		{
			return GetByLastName(lastName, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName)
		{
			return await GetByLastNameAsync(lastName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, TransactionManager tm_)
		{
			return GetByLastName(lastName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, int top_)
		{
			return GetByLastName(lastName, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, int top_)
		{
			return await GetByLastNameAsync(lastName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, int top_, TransactionManager tm_)
		{
			return GetByLastName(lastName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, int top_, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, string sort_)
		{
			return GetByLastName(lastName, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, string sort_)
		{
			return await GetByLastNameAsync(lastName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, string sort_, TransactionManager tm_)
		{
			return GetByLastName(lastName, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, string sort_, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">用户姓</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastName(string lastName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastName != null ? "`LastName` = @LastName" : "`LastName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastName != null)
				paras_.Add(Database.CreateInParameter("@LastName", lastName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastNameAsync(string lastName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastName != null ? "`LastName` = @LastName" : "`LastName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastName != null)
				paras_.Add(Database.CreateInParameter("@LastName", lastName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByLastName
		#region GetByExpiryDate
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate)
		{
			return GetByExpiryDate(expiryDate, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate)
		{
			return await GetByExpiryDateAsync(expiryDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, TransactionManager tm_)
		{
			return GetByExpiryDate(expiryDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, TransactionManager tm_)
		{
			return await GetByExpiryDateAsync(expiryDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, int top_)
		{
			return GetByExpiryDate(expiryDate, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, int top_)
		{
			return await GetByExpiryDateAsync(expiryDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, int top_, TransactionManager tm_)
		{
			return GetByExpiryDate(expiryDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, int top_, TransactionManager tm_)
		{
			return await GetByExpiryDateAsync(expiryDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, string sort_)
		{
			return GetByExpiryDate(expiryDate, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, string sort_)
		{
			return await GetByExpiryDateAsync(expiryDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, string sort_, TransactionManager tm_)
		{
			return GetByExpiryDate(expiryDate, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, string sort_, TransactionManager tm_)
		{
			return await GetByExpiryDateAsync(expiryDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ExpiryDate（字段） 查询
		/// </summary>
		/// /// <param name = "expiryDate">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByExpiryDate(string expiryDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(expiryDate != null ? "`ExpiryDate` = @ExpiryDate" : "`ExpiryDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (expiryDate != null)
				paras_.Add(Database.CreateInParameter("@ExpiryDate", expiryDate, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByExpiryDateAsync(string expiryDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(expiryDate != null ? "`ExpiryDate` = @ExpiryDate" : "`ExpiryDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (expiryDate != null)
				paras_.Add(Database.CreateInParameter("@ExpiryDate", expiryDate, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByExpiryDate
		#region GetByCVV
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV)
		{
			return GetByCVV(cVV, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV)
		{
			return await GetByCVVAsync(cVV, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, TransactionManager tm_)
		{
			return GetByCVV(cVV, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, TransactionManager tm_)
		{
			return await GetByCVVAsync(cVV, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, int top_)
		{
			return GetByCVV(cVV, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, int top_)
		{
			return await GetByCVVAsync(cVV, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, int top_, TransactionManager tm_)
		{
			return GetByCVV(cVV, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, int top_, TransactionManager tm_)
		{
			return await GetByCVVAsync(cVV, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, string sort_)
		{
			return GetByCVV(cVV, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, string sort_)
		{
			return await GetByCVVAsync(cVV, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, string sort_, TransactionManager tm_)
		{
			return GetByCVV(cVV, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, string sort_, TransactionManager tm_)
		{
			return await GetByCVVAsync(cVV, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CVV（字段） 查询
		/// </summary>
		/// /// <param name = "cVV">CVV</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCVV(string cVV, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cVV != null ? "`CVV` = @CVV" : "`CVV` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cVV != null)
				paras_.Add(Database.CreateInParameter("@CVV", cVV, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCVVAsync(string cVV, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cVV != null ? "`CVV` = @CVV" : "`CVV` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cVV != null)
				paras_.Add(Database.CreateInParameter("@CVV", cVV, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByCVV
		#region GetByPhoneNumber
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber)
		{
			return GetByPhoneNumber(phoneNumber, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, int top_)
		{
			return GetByPhoneNumber(phoneNumber, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, int top_, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, string sort_)
		{
			return GetByPhoneNumber(phoneNumber, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, string sort_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, string sort_, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, string sort_, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">电话号码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPhoneNumber(string phoneNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(phoneNumber != null ? "`PhoneNumber` = @PhoneNumber" : "`PhoneNumber` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (phoneNumber != null)
				paras_.Add(Database.CreateInParameter("@PhoneNumber", phoneNumber, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(phoneNumber != null ? "`PhoneNumber` = @PhoneNumber" : "`PhoneNumber` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (phoneNumber != null)
				paras_.Add(Database.CreateInParameter("@PhoneNumber", phoneNumber, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByPhoneNumber
		#region GetByEmail
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email)
		{
			return GetByEmail(email, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email)
		{
			return await GetByEmailAsync(email, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, TransactionManager tm_)
		{
			return GetByEmail(email, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, int top_)
		{
			return GetByEmail(email, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, int top_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, int top_, TransactionManager tm_)
		{
			return GetByEmail(email, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, int top_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, string sort_)
		{
			return GetByEmail(email, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, string sort_)
		{
			return await GetByEmailAsync(email, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, string sort_, TransactionManager tm_)
		{
			return GetByEmail(email, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, string sort_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByEmail(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByEmailAsync(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByEmail
		#region GetByState
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state)
		{
			return GetByState(state, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state)
		{
			return await GetByStateAsync(state, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, TransactionManager tm_)
		{
			return GetByState(state, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, int top_)
		{
			return GetByState(state, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, int top_)
		{
			return await GetByStateAsync(state, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, int top_, TransactionManager tm_)
		{
			return GetByState(state, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, int top_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, string sort_)
		{
			return GetByState(state, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, string sort_)
		{
			return await GetByStateAsync(state, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, string sort_, TransactionManager tm_)
		{
			return GetByState(state, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, string sort_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">州</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByState(string state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(state != null ? "`State` = @State" : "`State` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (state != null)
				paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStateAsync(string state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(state != null ? "`State` = @State" : "`State` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (state != null)
				paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByState
		#region GetByCity
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city)
		{
			return GetByCity(city, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city)
		{
			return await GetByCityAsync(city, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, TransactionManager tm_)
		{
			return GetByCity(city, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, TransactionManager tm_)
		{
			return await GetByCityAsync(city, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, int top_)
		{
			return GetByCity(city, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, int top_)
		{
			return await GetByCityAsync(city, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, int top_, TransactionManager tm_)
		{
			return GetByCity(city, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, int top_, TransactionManager tm_)
		{
			return await GetByCityAsync(city, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, string sort_)
		{
			return GetByCity(city, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, string sort_)
		{
			return await GetByCityAsync(city, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, string sort_, TransactionManager tm_)
		{
			return GetByCity(city, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, string sort_, TransactionManager tm_)
		{
			return await GetByCityAsync(city, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// /// <param name = "city">城市</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByCity(string city, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(city != null ? "`City` = @City" : "`City` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (city != null)
				paras_.Add(Database.CreateInParameter("@City", city, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByCityAsync(string city, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(city != null ? "`City` = @City" : "`City` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (city != null)
				paras_.Add(Database.CreateInParameter("@City", city, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByCity
		#region GetByStreet
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street)
		{
			return GetByStreet(street, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street)
		{
			return await GetByStreetAsync(street, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, TransactionManager tm_)
		{
			return GetByStreet(street, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, TransactionManager tm_)
		{
			return await GetByStreetAsync(street, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, int top_)
		{
			return GetByStreet(street, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, int top_)
		{
			return await GetByStreetAsync(street, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, int top_, TransactionManager tm_)
		{
			return GetByStreet(street, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, int top_, TransactionManager tm_)
		{
			return await GetByStreetAsync(street, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, string sort_)
		{
			return GetByStreet(street, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, string sort_)
		{
			return await GetByStreetAsync(street, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, string sort_, TransactionManager tm_)
		{
			return GetByStreet(street, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, string sort_, TransactionManager tm_)
		{
			return await GetByStreetAsync(street, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Street（字段） 查询
		/// </summary>
		/// /// <param name = "street">街道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByStreet(string street, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(street != null ? "`Street` = @Street" : "`Street` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (street != null)
				paras_.Add(Database.CreateInParameter("@Street", street, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByStreetAsync(string street, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(street != null ? "`Street` = @Street" : "`Street` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (street != null)
				paras_.Add(Database.CreateInParameter("@Street", street, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByStreet
		#region GetByPostalCode
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode)
		{
			return GetByPostalCode(postalCode, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode)
		{
			return await GetByPostalCodeAsync(postalCode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, TransactionManager tm_)
		{
			return GetByPostalCode(postalCode, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, TransactionManager tm_)
		{
			return await GetByPostalCodeAsync(postalCode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, int top_)
		{
			return GetByPostalCode(postalCode, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, int top_)
		{
			return await GetByPostalCodeAsync(postalCode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, int top_, TransactionManager tm_)
		{
			return GetByPostalCode(postalCode, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, int top_, TransactionManager tm_)
		{
			return await GetByPostalCodeAsync(postalCode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, string sort_)
		{
			return GetByPostalCode(postalCode, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, string sort_)
		{
			return await GetByPostalCodeAsync(postalCode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, string sort_, TransactionManager tm_)
		{
			return GetByPostalCode(postalCode, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, string sort_, TransactionManager tm_)
		{
			return await GetByPostalCodeAsync(postalCode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PostalCode（字段） 查询
		/// </summary>
		/// /// <param name = "postalCode">邮编</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByPostalCode(string postalCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(postalCode != null ? "`PostalCode` = @PostalCode" : "`PostalCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (postalCode != null)
				paras_.Add(Database.CreateInParameter("@PostalCode", postalCode, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByPostalCodeAsync(string postalCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(postalCode != null ? "`PostalCode` = @PostalCode" : "`PostalCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (postalCode != null)
				paras_.Add(Database.CreateInParameter("@PostalCode", postalCode, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByPostalCode
		#region GetByLastUsing
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing)
		{
			return GetByLastUsing(lastUsing, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing)
		{
			return await GetByLastUsingAsync(lastUsing, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, TransactionManager tm_)
		{
			return GetByLastUsing(lastUsing, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, TransactionManager tm_)
		{
			return await GetByLastUsingAsync(lastUsing, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, int top_)
		{
			return GetByLastUsing(lastUsing, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, int top_)
		{
			return await GetByLastUsingAsync(lastUsing, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, int top_, TransactionManager tm_)
		{
			return GetByLastUsing(lastUsing, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, int top_, TransactionManager tm_)
		{
			return await GetByLastUsingAsync(lastUsing, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, string sort_)
		{
			return GetByLastUsing(lastUsing, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, string sort_)
		{
			return await GetByLastUsingAsync(lastUsing, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, string sort_, TransactionManager tm_)
		{
			return GetByLastUsing(lastUsing, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, string sort_, TransactionManager tm_)
		{
			return await GetByLastUsingAsync(lastUsing, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastUsing（字段） 查询
		/// </summary>
		/// /// <param name = "lastUsing">最后充值、提现使用的卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByLastUsing(int lastUsing, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastUsing` = @LastUsing", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByLastUsingAsync(int lastUsing, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastUsing` = @LastUsing", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUsing", lastUsing, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByLastUsing
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<L_user_bank_infoEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByModifyDate
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate)
		{
			return GetByModifyDate(modifyDate, 0, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate)
		{
			return await GetByModifyDateAsync(modifyDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, TransactionManager tm_)
		{
			return GetByModifyDate(modifyDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, TransactionManager tm_)
		{
			return await GetByModifyDateAsync(modifyDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, int top_)
		{
			return GetByModifyDate(modifyDate, top_, string.Empty, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, int top_)
		{
			return await GetByModifyDateAsync(modifyDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, int top_, TransactionManager tm_)
		{
			return GetByModifyDate(modifyDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, int top_, TransactionManager tm_)
		{
			return await GetByModifyDateAsync(modifyDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, string sort_)
		{
			return GetByModifyDate(modifyDate, 0, sort_, null);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, string sort_)
		{
			return await GetByModifyDateAsync(modifyDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, string sort_, TransactionManager tm_)
		{
			return GetByModifyDate(modifyDate, 0, sort_, tm_);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, string sort_, TransactionManager tm_)
		{
			return await GetByModifyDateAsync(modifyDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ModifyDate（字段） 查询
		/// </summary>
		/// /// <param name = "modifyDate">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_bank_infoEO> GetByModifyDate(DateTime modifyDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ModifyDate` = @ModifyDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		public async Task<List<L_user_bank_infoEO>> GetByModifyDateAsync(DateTime modifyDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ModifyDate` = @ModifyDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ModifyDate", modifyDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_bank_infoEO.MapDataReader);
		}
		#endregion // GetByModifyDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
