/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-11 16: 05:40
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
	/// 每日充值，充值赠送bonus区间配置表
	/// 【表 sa_userpay100008_detail_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_userpay100008_detail_configEO : IRowMapper<Sa_userpay100008_detail_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_userpay100008_detail_configEO()
		{
			this.PayAmountStart = 0;
			this.PayAmountEnd = 0;
			this.SendBonusMultip = 0.00f;
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
		/// 充值金额起始值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long PayAmountStart { get; set; }
		/// <summary>
		/// 充值金额截止值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long PayAmountEnd { get; set; }
		/// <summary>
		/// 赠送bonus倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 7)]
		public float SendBonusMultip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_userpay100008_detail_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_userpay100008_detail_configEO MapDataReader(IDataReader reader)
		{
		    Sa_userpay100008_detail_configEO ret = new Sa_userpay100008_detail_configEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.PayAmountStart = reader.ToInt64("PayAmountStart");
			ret.PayAmountEnd = reader.ToInt64("PayAmountEnd");
			ret.SendBonusMultip = reader.ToSingle("SendBonusMultip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 每日充值，充值赠送bonus区间配置表
	/// 【表 sa_userpay100008_detail_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_userpay100008_detail_configMO : MySqlTableMO<Sa_userpay100008_detail_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_userpay100008_detail_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_userpay100008_detail_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_userpay100008_detail_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_userpay100008_detail_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_userpay100008_detail_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `OperatorID`, `CountryId`, `CurrencyID`, `PayAmountStart`, `PayAmountEnd`, `SendBonusMultip`) VALUE (@DetailID, @OperatorID, @CountryId, @CurrencyID, @PayAmountStart, @PayAmountEnd, @SendBonusMultip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayAmountStart", item.PayAmountStart, MySqlDbType.Int64),
				Database.CreateInParameter("@PayAmountEnd", item.PayAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@SendBonusMultip", item.SendBonusMultip, MySqlDbType.Float),
			};
		}
		public int AddByBatch(IEnumerable<Sa_userpay100008_detail_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_userpay100008_detail_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_userpay100008_detail_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `OperatorID`, `CountryId`, `CurrencyID`, `PayAmountStart`, `PayAmountEnd`, `SendBonusMultip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.PayAmountStart},{item.PayAmountEnd},{item.SendBonusMultip}),");
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
		public int Remove(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByPayAmountStart
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAmountStart(long payAmountStart, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountStartData(payAmountStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAmountStartAsync(long payAmountStart, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountStartData(payAmountStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAmountStartData(long payAmountStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAmountStart` = @PayAmountStart";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAmountStart
		#region RemoveByPayAmountEnd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAmountEnd(long payAmountEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountEndData(payAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAmountEndAsync(long payAmountEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountEndData(payAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAmountEndData(long payAmountEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAmountEnd` = @PayAmountEnd";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAmountEnd
		#region RemoveBySendBonusMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySendBonusMultip(float sendBonusMultip, TransactionManager tm_ = null)
		{
			RepairRemoveBySendBonusMultipData(sendBonusMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySendBonusMultipAsync(float sendBonusMultip, TransactionManager tm_ = null)
		{
			RepairRemoveBySendBonusMultipData(sendBonusMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySendBonusMultipData(float sendBonusMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SendBonusMultip` = @SendBonusMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float));
		}
		#endregion // RemoveBySendBonusMultip
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
		public int Put(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_userpay100008_detail_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_userpay100008_detail_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `PayAmountStart` = @PayAmountStart, `PayAmountEnd` = @PayAmountEnd, `SendBonusMultip` = @SendBonusMultip WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayAmountStart", item.PayAmountStart, MySqlDbType.Int64),
				Database.CreateInParameter("@PayAmountEnd", item.PayAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@SendBonusMultip", item.SendBonusMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_userpay100008_detail_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_userpay100008_detail_configEO> items, TransactionManager tm_ = null)
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
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
		#region PutPayAmountStart
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountStartByPK(string detailID, long payAmountStart, TransactionManager tm_ = null)
		{
			RepairPutPayAmountStartByPKData(detailID, payAmountStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountStartByPKAsync(string detailID, long payAmountStart, TransactionManager tm_ = null)
		{
			RepairPutPayAmountStartByPKData(detailID, payAmountStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountStartByPKData(string detailID, long payAmountStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmountStart` = @PayAmountStart  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountStart(long payAmountStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmountStart` = @PayAmountStart";
			var parameter_ = Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAmountStartAsync(long payAmountStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmountStart` = @PayAmountStart";
			var parameter_ = Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAmountStart
		#region PutPayAmountEnd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountEndByPK(string detailID, long payAmountEnd, TransactionManager tm_ = null)
		{
			RepairPutPayAmountEndByPKData(detailID, payAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountEndByPKAsync(string detailID, long payAmountEnd, TransactionManager tm_ = null)
		{
			RepairPutPayAmountEndByPKData(detailID, payAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountEndByPKData(string detailID, long payAmountEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmountEnd` = @PayAmountEnd  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountEnd(long payAmountEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmountEnd` = @PayAmountEnd";
			var parameter_ = Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAmountEndAsync(long payAmountEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmountEnd` = @PayAmountEnd";
			var parameter_ = Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAmountEnd
		#region PutSendBonusMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSendBonusMultipByPK(string detailID, float sendBonusMultip, TransactionManager tm_ = null)
		{
			RepairPutSendBonusMultipByPKData(detailID, sendBonusMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSendBonusMultipByPKAsync(string detailID, float sendBonusMultip, TransactionManager tm_ = null)
		{
			RepairPutSendBonusMultipByPKData(detailID, sendBonusMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSendBonusMultipByPKData(string detailID, float sendBonusMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SendBonusMultip` = @SendBonusMultip  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSendBonusMultip(float sendBonusMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SendBonusMultip` = @SendBonusMultip";
			var parameter_ = Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSendBonusMultipAsync(float sendBonusMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SendBonusMultip` = @SendBonusMultip";
			var parameter_ = Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSendBonusMultip
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_userpay100008_detail_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sa_userpay100008_detail_configEO item, TransactionManager tm = null)
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
		public Sa_userpay100008_detail_configEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<Sa_userpay100008_detail_configEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
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
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
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
		/// 按主键查询 PayAmountStart（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountStartByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAmountStart`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetPayAmountStartByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAmountStart`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayAmountEnd（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountEndByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAmountEnd`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetPayAmountEndByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAmountEnd`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SendBonusMultip（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetSendBonusMultipByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`SendBonusMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<float> GetSendBonusMultipByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`SendBonusMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_userpay100008_detail_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_userpay100008_detail_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByPayAmountStart
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart)
		{
			return GetByPayAmountStart(payAmountStart, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart)
		{
			return await GetByPayAmountStartAsync(payAmountStart, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, TransactionManager tm_)
		{
			return GetByPayAmountStart(payAmountStart, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, TransactionManager tm_)
		{
			return await GetByPayAmountStartAsync(payAmountStart, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, int top_)
		{
			return GetByPayAmountStart(payAmountStart, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, int top_)
		{
			return await GetByPayAmountStartAsync(payAmountStart, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, int top_, TransactionManager tm_)
		{
			return GetByPayAmountStart(payAmountStart, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountStartAsync(payAmountStart, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, string sort_)
		{
			return GetByPayAmountStart(payAmountStart, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, string sort_)
		{
			return await GetByPayAmountStartAsync(payAmountStart, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, string sort_, TransactionManager tm_)
		{
			return GetByPayAmountStart(payAmountStart, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountStartAsync(payAmountStart, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountStart（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountStart">充值金额起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountStart(long payAmountStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmountStart` = @PayAmountStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountStartAsync(long payAmountStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmountStart` = @PayAmountStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountStart", payAmountStart, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetByPayAmountStart
		#region GetByPayAmountEnd
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd)
		{
			return GetByPayAmountEnd(payAmountEnd, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, TransactionManager tm_)
		{
			return GetByPayAmountEnd(payAmountEnd, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, TransactionManager tm_)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, int top_)
		{
			return GetByPayAmountEnd(payAmountEnd, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, int top_)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, int top_, TransactionManager tm_)
		{
			return GetByPayAmountEnd(payAmountEnd, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, string sort_)
		{
			return GetByPayAmountEnd(payAmountEnd, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, string sort_)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, string sort_, TransactionManager tm_)
		{
			return GetByPayAmountEnd(payAmountEnd, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountEndAsync(payAmountEnd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "payAmountEnd">充值金额截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetByPayAmountEnd(long payAmountEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmountEnd` = @PayAmountEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetByPayAmountEndAsync(long payAmountEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmountEnd` = @PayAmountEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmountEnd", payAmountEnd, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetByPayAmountEnd
		#region GetBySendBonusMultip
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip)
		{
			return GetBySendBonusMultip(sendBonusMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, TransactionManager tm_)
		{
			return GetBySendBonusMultip(sendBonusMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, TransactionManager tm_)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, int top_)
		{
			return GetBySendBonusMultip(sendBonusMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, int top_)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, int top_, TransactionManager tm_)
		{
			return GetBySendBonusMultip(sendBonusMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, int top_, TransactionManager tm_)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, string sort_)
		{
			return GetBySendBonusMultip(sendBonusMultip, 0, sort_, null);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, string sort_)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, string sort_, TransactionManager tm_)
		{
			return GetBySendBonusMultip(sendBonusMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, string sort_, TransactionManager tm_)
		{
			return await GetBySendBonusMultipAsync(sendBonusMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SendBonusMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sendBonusMultip">赠送bonus倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_userpay100008_detail_configEO> GetBySendBonusMultip(float sendBonusMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SendBonusMultip` = @SendBonusMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		public async Task<List<Sa_userpay100008_detail_configEO>> GetBySendBonusMultipAsync(float sendBonusMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SendBonusMultip` = @SendBonusMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SendBonusMultip", sendBonusMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_userpay100008_detail_configEO.MapDataReader);
		}
		#endregion // GetBySendBonusMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
