/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-01-02 15: 38:06
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
	/// 用户国家个人信息
	/// 【表 l_user_info 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_user_infoEO : IRowMapper<L_user_infoEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_user_infoEO()
		{
			this.UserKind = 0;
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
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
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
		/// 用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int UserKind { get; set; }
		/// <summary>
		/// 用户昵称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 6)]
		public string NickName { get; set; }
		/// <summary>
		/// First Name
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string FirstName { get; set; }
		/// <summary>
		/// Last Name
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string LastName { get; set; }
		/// <summary>
		/// 生日
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime? BirthDay { get; set; }
		/// <summary>
		/// 证件号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string IDCard { get; set; }
		/// <summary>
		/// 手机号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 11)]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 邮箱
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 12)]
		public string Email { get; set; }
		/// <summary>
		/// 地址
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Address { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_user_infoEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_user_infoEO MapDataReader(IDataReader reader)
		{
		    L_user_infoEO ret = new L_user_infoEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.NickName = reader.ToString("NickName");
			ret.FirstName = reader.ToString("FirstName");
			ret.LastName = reader.ToString("LastName");
			ret.BirthDay = reader.ToDateTimeN("BirthDay");
			ret.IDCard = reader.ToString("IDCard");
			ret.PhoneNumber = reader.ToString("PhoneNumber");
			ret.Email = reader.ToString("Email");
			ret.Address = reader.ToString("Address");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户国家个人信息
	/// 【表 l_user_info 的操作类】
	/// </summary>
	[Obsolete]
	public class L_user_infoMO : MySqlTableMO<L_user_infoEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_user_info`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_user_infoMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_user_infoMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_user_infoMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_user_infoEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_user_infoEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_user_infoEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `OperatorID`, `CountryID`, `CurrencyID`, `UserKind`, `NickName`, `FirstName`, `LastName`, `BirthDay`, `IDCard`, `PhoneNumber`, `Email`, `Address`, `RecDate`) VALUE (@UserID, @OperatorID, @CountryID, @CurrencyID, @UserKind, @NickName, @FirstName, @LastName, @BirthDay, @IDCard, @PhoneNumber, @Email, @Address, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@NickName", item.NickName != null ? item.NickName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FirstName", item.FirstName != null ? item.FirstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastName", item.LastName != null ? item.LastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BirthDay", item.BirthDay.HasValue ? item.BirthDay.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IDCard", item.IDCard != null ? item.IDCard : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PhoneNumber", item.PhoneNumber != null ? item.PhoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Address", item.Address != null ? item.Address : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_user_infoEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_user_infoEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_user_infoEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `OperatorID`, `CountryID`, `CurrencyID`, `UserKind`, `NickName`, `FirstName`, `LastName`, `BirthDay`, `IDCard`, `PhoneNumber`, `Email`, `Address`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.UserKind},'{item.NickName}','{item.FirstName}','{item.LastName}','{item.BirthDay?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.IDCard}','{item.PhoneNumber}','{item.Email}','{item.Address}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		public int Remove(L_user_infoEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(L_user_infoEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
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
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
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
		#region RemoveByNickName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNickName(string nickName, TransactionManager tm_ = null)
		{
			RepairRemoveByNickNameData(nickName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNickNameAsync(string nickName, TransactionManager tm_ = null)
		{
			RepairRemoveByNickNameData(nickName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNickNameData(string nickName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (nickName != null ? "`NickName` = @NickName" : "`NickName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (nickName != null)
				paras_.Add(Database.CreateInParameter("@NickName", nickName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNickName
		#region RemoveByFirstName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
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
		/// /// <param name = "lastName">Last Name</param>
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
		#region RemoveByBirthDay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBirthDay(DateTime? birthDay, TransactionManager tm_ = null)
		{
			RepairRemoveByBirthDayData(birthDay.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBirthDayAsync(DateTime? birthDay, TransactionManager tm_ = null)
		{
			RepairRemoveByBirthDayData(birthDay.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBirthDayData(DateTime? birthDay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (birthDay.HasValue ? "`BirthDay` = @BirthDay" : "`BirthDay` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (birthDay.HasValue)
				paras_.Add(Database.CreateInParameter("@BirthDay", birthDay.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByBirthDay
		#region RemoveByIDCard
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIDCard(string iDCard, TransactionManager tm_ = null)
		{
			RepairRemoveByIDCardData(iDCard, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIDCardAsync(string iDCard, TransactionManager tm_ = null)
		{
			RepairRemoveByIDCardData(iDCard, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIDCardData(string iDCard, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (iDCard != null ? "`IDCard` = @IDCard" : "`IDCard` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (iDCard != null)
				paras_.Add(Database.CreateInParameter("@IDCard", iDCard, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIDCard
		#region RemoveByPhoneNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
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
		#region RemoveByAddress
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAddress(string address, TransactionManager tm_ = null)
		{
			RepairRemoveByAddressData(address, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAddressAsync(string address, TransactionManager tm_ = null)
		{
			RepairRemoveByAddressData(address, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAddressData(string address, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (address != null ? "`Address` = @Address" : "`Address` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (address != null)
				paras_.Add(Database.CreateInParameter("@Address", address, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAddress
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
		public int Put(L_user_infoEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_user_infoEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_user_infoEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `UserKind` = @UserKind, `NickName` = @NickName, `FirstName` = @FirstName, `LastName` = @LastName, `BirthDay` = @BirthDay, `IDCard` = @IDCard, `PhoneNumber` = @PhoneNumber, `Email` = @Email, `Address` = @Address WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@NickName", item.NickName != null ? item.NickName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FirstName", item.FirstName != null ? item.FirstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LastName", item.LastName != null ? item.LastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BirthDay", item.BirthDay.HasValue ? item.BirthDay.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IDCard", item.IDCard != null ? item.IDCard : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PhoneNumber", item.PhoneNumber != null ? item.PhoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Address", item.Address != null ? item.Address : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_user_infoEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_user_infoEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string userID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
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
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
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
		#region PutNickName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNickNameByPK(string userID, string nickName, TransactionManager tm_ = null)
		{
			RepairPutNickNameByPKData(userID, nickName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNickNameByPKAsync(string userID, string nickName, TransactionManager tm_ = null)
		{
			RepairPutNickNameByPKData(userID, nickName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNickNameByPKData(string userID, string nickName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NickName` = @NickName  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NickName", nickName != null ? nickName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNickName(string nickName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NickName` = @NickName";
			var parameter_ = Database.CreateInParameter("@NickName", nickName != null ? nickName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNickNameAsync(string nickName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NickName` = @NickName";
			var parameter_ = Database.CreateInParameter("@NickName", nickName != null ? nickName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNickName
		#region PutFirstName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "firstName">First Name</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstNameByPK(string userID, string firstName, TransactionManager tm_ = null)
		{
			RepairPutFirstNameByPKData(userID, firstName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstNameByPKAsync(string userID, string firstName, TransactionManager tm_ = null)
		{
			RepairPutFirstNameByPKData(userID, firstName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstNameByPKData(string userID, string firstName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstName` = @FirstName  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstName", firstName != null ? firstName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastNameByPK(string userID, string lastName, TransactionManager tm_ = null)
		{
			RepairPutLastNameByPKData(userID, lastName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastNameByPKAsync(string userID, string lastName, TransactionManager tm_ = null)
		{
			RepairPutLastNameByPKData(userID, lastName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastNameByPKData(string userID, string lastName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastName` = @LastName  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastName", lastName != null ? lastName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
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
		#region PutBirthDay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "birthDay">生日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBirthDayByPK(string userID, DateTime? birthDay, TransactionManager tm_ = null)
		{
			RepairPutBirthDayByPKData(userID, birthDay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBirthDayByPKAsync(string userID, DateTime? birthDay, TransactionManager tm_ = null)
		{
			RepairPutBirthDayByPKData(userID, birthDay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBirthDayByPKData(string userID, DateTime? birthDay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BirthDay` = @BirthDay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BirthDay", birthDay.HasValue ? birthDay.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBirthDay(DateTime? birthDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BirthDay` = @BirthDay";
			var parameter_ = Database.CreateInParameter("@BirthDay", birthDay.HasValue ? birthDay.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBirthDayAsync(DateTime? birthDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BirthDay` = @BirthDay";
			var parameter_ = Database.CreateInParameter("@BirthDay", birthDay.HasValue ? birthDay.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBirthDay
		#region PutIDCard
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIDCardByPK(string userID, string iDCard, TransactionManager tm_ = null)
		{
			RepairPutIDCardByPKData(userID, iDCard, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIDCardByPKAsync(string userID, string iDCard, TransactionManager tm_ = null)
		{
			RepairPutIDCardByPKData(userID, iDCard, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIDCardByPKData(string userID, string iDCard, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IDCard` = @IDCard  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IDCard", iDCard != null ? iDCard : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIDCard(string iDCard, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IDCard` = @IDCard";
			var parameter_ = Database.CreateInParameter("@IDCard", iDCard != null ? iDCard : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIDCardAsync(string iDCard, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IDCard` = @IDCard";
			var parameter_ = Database.CreateInParameter("@IDCard", iDCard != null ? iDCard : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIDCard
		#region PutPhoneNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPhoneNumberByPK(string userID, string phoneNumber, TransactionManager tm_ = null)
		{
			RepairPutPhoneNumberByPKData(userID, phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPhoneNumberByPKAsync(string userID, string phoneNumber, TransactionManager tm_ = null)
		{
			RepairPutPhoneNumberByPKData(userID, phoneNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPhoneNumberByPKData(string userID, string phoneNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PhoneNumber` = @PhoneNumber  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PhoneNumber", phoneNumber != null ? phoneNumber : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmailByPK(string userID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userID, email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEmailByPKAsync(string userID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userID, email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEmailByPKData(string userID, string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Email` = @Email  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutAddress
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "address">地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAddressByPK(string userID, string address, TransactionManager tm_ = null)
		{
			RepairPutAddressByPKData(userID, address, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAddressByPKAsync(string userID, string address, TransactionManager tm_ = null)
		{
			RepairPutAddressByPKData(userID, address, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAddressByPKData(string userID, string address, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Address` = @Address  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Address", address != null ? address : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAddress(string address, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Address` = @Address";
			var parameter_ = Database.CreateInParameter("@Address", address != null ? address : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAddressAsync(string address, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Address` = @Address";
			var parameter_ = Database.CreateInParameter("@Address", address != null ? address : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAddress
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		public bool Set(L_user_infoEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(L_user_infoEO item, TransactionManager tm = null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_user_infoEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<L_user_infoEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
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
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		/// 按主键查询 NickName（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNickNameByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NickName`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetNickNameByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NickName`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstName（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFirstNameByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FirstName`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFirstNameByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FirstName`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastName（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLastNameByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LastName`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetLastNameByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LastName`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BirthDay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetBirthDayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`BirthDay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetBirthDayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`BirthDay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IDCard（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIDCardByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IDCard`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetIDCardByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IDCard`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PhoneNumber（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPhoneNumberByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PhoneNumber`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPhoneNumberByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PhoneNumber`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Email（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEmailByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Email`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetEmailByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Email`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Address（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAddressByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Address`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetAddressByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Address`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<L_user_infoEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<L_user_infoEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<L_user_infoEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<L_user_infoEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<L_user_infoEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<L_user_infoEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<L_user_infoEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByNickName
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName)
		{
			return GetByNickName(nickName, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName)
		{
			return await GetByNickNameAsync(nickName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, TransactionManager tm_)
		{
			return GetByNickName(nickName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, TransactionManager tm_)
		{
			return await GetByNickNameAsync(nickName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, int top_)
		{
			return GetByNickName(nickName, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, int top_)
		{
			return await GetByNickNameAsync(nickName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, int top_, TransactionManager tm_)
		{
			return GetByNickName(nickName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, int top_, TransactionManager tm_)
		{
			return await GetByNickNameAsync(nickName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, string sort_)
		{
			return GetByNickName(nickName, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, string sort_)
		{
			return await GetByNickNameAsync(nickName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, string sort_, TransactionManager tm_)
		{
			return GetByNickName(nickName, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, string sort_, TransactionManager tm_)
		{
			return await GetByNickNameAsync(nickName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// /// <param name = "nickName">用户昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByNickName(string nickName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(nickName != null ? "`NickName` = @NickName" : "`NickName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (nickName != null)
				paras_.Add(Database.CreateInParameter("@NickName", nickName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByNickNameAsync(string nickName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(nickName != null ? "`NickName` = @NickName" : "`NickName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (nickName != null)
				paras_.Add(Database.CreateInParameter("@NickName", nickName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByNickName
		#region GetByFirstName
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName)
		{
			return GetByFirstName(firstName, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName)
		{
			return await GetByFirstNameAsync(firstName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, TransactionManager tm_)
		{
			return GetByFirstName(firstName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, int top_)
		{
			return GetByFirstName(firstName, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, int top_)
		{
			return await GetByFirstNameAsync(firstName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, int top_, TransactionManager tm_)
		{
			return GetByFirstName(firstName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, int top_, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, string sort_)
		{
			return GetByFirstName(firstName, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, string sort_)
		{
			return await GetByFirstNameAsync(firstName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, string sort_, TransactionManager tm_)
		{
			return GetByFirstName(firstName, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, string sort_, TransactionManager tm_)
		{
			return await GetByFirstNameAsync(firstName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstName（字段） 查询
		/// </summary>
		/// /// <param name = "firstName">First Name</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByFirstName(string firstName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstName != null ? "`FirstName` = @FirstName" : "`FirstName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstName != null)
				paras_.Add(Database.CreateInParameter("@FirstName", firstName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByFirstNameAsync(string firstName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(firstName != null ? "`FirstName` = @FirstName" : "`FirstName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (firstName != null)
				paras_.Add(Database.CreateInParameter("@FirstName", firstName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByFirstName
		#region GetByLastName
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName)
		{
			return GetByLastName(lastName, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName)
		{
			return await GetByLastNameAsync(lastName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, TransactionManager tm_)
		{
			return GetByLastName(lastName, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, int top_)
		{
			return GetByLastName(lastName, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, int top_)
		{
			return await GetByLastNameAsync(lastName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, int top_, TransactionManager tm_)
		{
			return GetByLastName(lastName, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, int top_, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, string sort_)
		{
			return GetByLastName(lastName, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, string sort_)
		{
			return await GetByLastNameAsync(lastName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, string sort_, TransactionManager tm_)
		{
			return GetByLastName(lastName, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, string sort_, TransactionManager tm_)
		{
			return await GetByLastNameAsync(lastName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastName（字段） 查询
		/// </summary>
		/// /// <param name = "lastName">Last Name</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByLastName(string lastName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastName != null ? "`LastName` = @LastName" : "`LastName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastName != null)
				paras_.Add(Database.CreateInParameter("@LastName", lastName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByLastNameAsync(string lastName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastName != null ? "`LastName` = @LastName" : "`LastName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastName != null)
				paras_.Add(Database.CreateInParameter("@LastName", lastName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByLastName
		#region GetByBirthDay
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay)
		{
			return GetByBirthDay(birthDay, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay)
		{
			return await GetByBirthDayAsync(birthDay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, TransactionManager tm_)
		{
			return GetByBirthDay(birthDay, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, TransactionManager tm_)
		{
			return await GetByBirthDayAsync(birthDay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, int top_)
		{
			return GetByBirthDay(birthDay, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, int top_)
		{
			return await GetByBirthDayAsync(birthDay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, int top_, TransactionManager tm_)
		{
			return GetByBirthDay(birthDay, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, int top_, TransactionManager tm_)
		{
			return await GetByBirthDayAsync(birthDay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, string sort_)
		{
			return GetByBirthDay(birthDay, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, string sort_)
		{
			return await GetByBirthDayAsync(birthDay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, string sort_, TransactionManager tm_)
		{
			return GetByBirthDay(birthDay, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, string sort_, TransactionManager tm_)
		{
			return await GetByBirthDayAsync(birthDay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BirthDay（字段） 查询
		/// </summary>
		/// /// <param name = "birthDay">生日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByBirthDay(DateTime? birthDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(birthDay.HasValue ? "`BirthDay` = @BirthDay" : "`BirthDay` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (birthDay.HasValue)
				paras_.Add(Database.CreateInParameter("@BirthDay", birthDay.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByBirthDayAsync(DateTime? birthDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(birthDay.HasValue ? "`BirthDay` = @BirthDay" : "`BirthDay` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (birthDay.HasValue)
				paras_.Add(Database.CreateInParameter("@BirthDay", birthDay.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByBirthDay
		#region GetByIDCard
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard)
		{
			return GetByIDCard(iDCard, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard)
		{
			return await GetByIDCardAsync(iDCard, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, TransactionManager tm_)
		{
			return GetByIDCard(iDCard, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, TransactionManager tm_)
		{
			return await GetByIDCardAsync(iDCard, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, int top_)
		{
			return GetByIDCard(iDCard, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, int top_)
		{
			return await GetByIDCardAsync(iDCard, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, int top_, TransactionManager tm_)
		{
			return GetByIDCard(iDCard, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, int top_, TransactionManager tm_)
		{
			return await GetByIDCardAsync(iDCard, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, string sort_)
		{
			return GetByIDCard(iDCard, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, string sort_)
		{
			return await GetByIDCardAsync(iDCard, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, string sort_, TransactionManager tm_)
		{
			return GetByIDCard(iDCard, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, string sort_, TransactionManager tm_)
		{
			return await GetByIDCardAsync(iDCard, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IDCard（字段） 查询
		/// </summary>
		/// /// <param name = "iDCard">证件号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByIDCard(string iDCard, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iDCard != null ? "`IDCard` = @IDCard" : "`IDCard` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iDCard != null)
				paras_.Add(Database.CreateInParameter("@IDCard", iDCard, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByIDCardAsync(string iDCard, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iDCard != null ? "`IDCard` = @IDCard" : "`IDCard` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iDCard != null)
				paras_.Add(Database.CreateInParameter("@IDCard", iDCard, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByIDCard
		#region GetByPhoneNumber
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber)
		{
			return GetByPhoneNumber(phoneNumber, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, int top_)
		{
			return GetByPhoneNumber(phoneNumber, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, int top_, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, string sort_)
		{
			return GetByPhoneNumber(phoneNumber, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, string sort_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, string sort_, TransactionManager tm_)
		{
			return GetByPhoneNumber(phoneNumber, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, string sort_, TransactionManager tm_)
		{
			return await GetByPhoneNumberAsync(phoneNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PhoneNumber（字段） 查询
		/// </summary>
		/// /// <param name = "phoneNumber">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByPhoneNumber(string phoneNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(phoneNumber != null ? "`PhoneNumber` = @PhoneNumber" : "`PhoneNumber` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (phoneNumber != null)
				paras_.Add(Database.CreateInParameter("@PhoneNumber", phoneNumber, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByPhoneNumberAsync(string phoneNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(phoneNumber != null ? "`PhoneNumber` = @PhoneNumber" : "`PhoneNumber` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (phoneNumber != null)
				paras_.Add(Database.CreateInParameter("@PhoneNumber", phoneNumber, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByPhoneNumber
		#region GetByEmail
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByEmail(string email)
		{
			return GetByEmail(email, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email)
		{
			return await GetByEmailAsync(email, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByEmail(string email, TransactionManager tm_)
		{
			return GetByEmail(email, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByEmail(string email, int top_)
		{
			return GetByEmail(email, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, int top_)
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
		public List<L_user_infoEO> GetByEmail(string email, int top_, TransactionManager tm_)
		{
			return GetByEmail(email, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, int top_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByEmail(string email, string sort_)
		{
			return GetByEmail(email, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, string sort_)
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
		public List<L_user_infoEO> GetByEmail(string email, string sort_, TransactionManager tm_)
		{
			return GetByEmail(email, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, string sort_, TransactionManager tm_)
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
		public List<L_user_infoEO> GetByEmail(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByEmailAsync(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByEmail
		#region GetByAddress
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address)
		{
			return GetByAddress(address, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address)
		{
			return await GetByAddressAsync(address, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, TransactionManager tm_)
		{
			return GetByAddress(address, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, TransactionManager tm_)
		{
			return await GetByAddressAsync(address, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, int top_)
		{
			return GetByAddress(address, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, int top_)
		{
			return await GetByAddressAsync(address, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, int top_, TransactionManager tm_)
		{
			return GetByAddress(address, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, int top_, TransactionManager tm_)
		{
			return await GetByAddressAsync(address, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, string sort_)
		{
			return GetByAddress(address, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, string sort_)
		{
			return await GetByAddressAsync(address, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, string sort_, TransactionManager tm_)
		{
			return GetByAddress(address, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, string sort_, TransactionManager tm_)
		{
			return await GetByAddressAsync(address, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Address（字段） 查询
		/// </summary>
		/// /// <param name = "address">地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByAddress(string address, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(address != null ? "`Address` = @Address" : "`Address` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (address != null)
				paras_.Add(Database.CreateInParameter("@Address", address, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByAddressAsync(string address, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(address != null ? "`Address` = @Address" : "`Address` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (address != null)
				paras_.Add(Database.CreateInParameter("@Address", address, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByAddress
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<L_user_infoEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		public async Task<List<L_user_infoEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_infoEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
