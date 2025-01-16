/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:52
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
	/// 【表 sb_bank_paytype_channel 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sb_bank_paytype_channelEO : IRowMapper<Sb_bank_paytype_channelEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sb_bank_paytype_channelEO()
		{
			this.PaytypeID = 0;
			this.PaytypeChannel = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalBankID;
		/// <summary>
		/// 【数据库中的原始主键 BankID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBankID
		{
			get { return _originalBankID; }
			set { HasOriginal = true; _originalBankID = value; }
		}
		
		private int _originalPaytypeID;
		/// <summary>
		/// 【数据库中的原始主键 PaytypeID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPaytypeID
		{
			get { return _originalPaytypeID; }
			set { HasOriginal = true; _originalPaytypeID = value; }
		}
		
		private int _originalPaytypeChannel;
		/// <summary>
		/// 【数据库中的原始主键 PaytypeChannel 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPaytypeChannel
		{
			get { return _originalPaytypeChannel; }
			set { HasOriginal = true; _originalPaytypeChannel = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BankID", BankID },  { "PaytypeID", PaytypeID },  { "PaytypeChannel", PaytypeChannel }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 银行编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string BankID { get; set; }
		/// <summary>
		/// 支付方式0-综合1-visa2-spei
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int PaytypeID { get; set; }
		/// <summary>
		/// 支付方式下的渠道
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int PaytypeChannel { get; set; }
		/// <summary>
		/// 渠道名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ChannelName { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sb_bank_paytype_channelEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sb_bank_paytype_channelEO MapDataReader(IDataReader reader)
		{
		    Sb_bank_paytype_channelEO ret = new Sb_bank_paytype_channelEO();
			ret.BankID = reader.ToString("BankID");
			ret.OriginalBankID = ret.BankID;
			ret.PaytypeID = reader.ToInt32("PaytypeID");
			ret.OriginalPaytypeID = ret.PaytypeID;
			ret.PaytypeChannel = reader.ToInt32("PaytypeChannel");
			ret.OriginalPaytypeChannel = ret.PaytypeChannel;
			ret.ChannelName = reader.ToString("ChannelName");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sb_bank_paytype_channel 的操作类】
	/// </summary>
	[Obsolete]
	public class Sb_bank_paytype_channelMO : MySqlTableMO<Sb_bank_paytype_channelEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sb_bank_paytype_channel`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sb_bank_paytype_channelMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sb_bank_paytype_channelMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sb_bank_paytype_channelMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sb_bank_paytype_channelEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BankID`, `PaytypeID`, `PaytypeChannel`, `ChannelName`) VALUE (@BankID, @PaytypeID, @PaytypeChannel, @ChannelName);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", item.PaytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", item.PaytypeChannel, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelName", item.ChannelName != null ? item.ChannelName : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sb_bank_paytype_channelEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sb_bank_paytype_channelEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sb_bank_paytype_channelEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BankID`, `PaytypeID`, `PaytypeChannel`, `ChannelName`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.BankID}',{item.PaytypeID},{item.PaytypeChannel},'{item.ChannelName}'),");
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bankID, paytypeID, paytypeChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bankID, paytypeID, paytypeChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string bankID, int paytypeID, int paytypeChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BankID, item.PaytypeID, item.PaytypeChannel, tm_);
		}
		public async Task<int> RemoveAsync(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BankID, item.PaytypeID, item.PaytypeChannel, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBankID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankID(string bankID, TransactionManager tm_ = null)
		{
			RepairRemoveByBankIDData(bankID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankIDAsync(string bankID, TransactionManager tm_ = null)
		{
			RepairRemoveByBankIDData(bankID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankIDData(string bankID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BankID` = @BankID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankID
		#region RemoveByPaytypeID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaytypeID(int paytypeID, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeIDData(paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaytypeIDAsync(int paytypeID, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeIDData(paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaytypeIDData(int paytypeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
		}
		#endregion // RemoveByPaytypeID
		#region RemoveByPaytypeChannel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaytypeChannel(int paytypeChannel, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeChannelData(paytypeChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaytypeChannelAsync(int paytypeChannel, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeChannelData(paytypeChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaytypeChannelData(int paytypeChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaytypeChannel` = @PaytypeChannel";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32));
		}
		#endregion // RemoveByPaytypeChannel
		#region RemoveByChannelName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChannelName(string channelName, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelNameData(channelName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChannelNameAsync(string channelName, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelNameData(channelName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChannelNameData(string channelName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (channelName != null ? "`ChannelName` = @ChannelName" : "`ChannelName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (channelName != null)
				paras_.Add(Database.CreateInParameter("@ChannelName", channelName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByChannelName
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
		public int Put(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sb_bank_paytype_channelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sb_bank_paytype_channelEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankID` = @BankID, `PaytypeID` = @PaytypeID, `PaytypeChannel` = @PaytypeChannel, `ChannelName` = @ChannelName WHERE `BankID` = @BankID_Original AND `PaytypeID` = @PaytypeID_Original AND `PaytypeChannel` = @PaytypeChannel_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", item.PaytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", item.PaytypeChannel, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelName", item.ChannelName != null ? item.ChannelName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID_Original", item.HasOriginal ? item.OriginalBankID : item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID_Original", item.HasOriginal ? item.OriginalPaytypeID : item.PaytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel_Original", item.HasOriginal ? item.OriginalPaytypeChannel : item.PaytypeChannel, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sb_bank_paytype_channelEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sb_bank_paytype_channelEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bankID, int paytypeID, int paytypeChannel, string set_, params object[] values_)
		{
			return Put(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", ConcatValues(values_, bankID, paytypeID, paytypeChannel));
		}
		public async Task<int> PutByPKAsync(string bankID, int paytypeID, int paytypeChannel, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", ConcatValues(values_, bankID, paytypeID, paytypeChannel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bankID, int paytypeID, int paytypeChannel, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", tm_, ConcatValues(values_, bankID, paytypeID, paytypeChannel));
		}
		public async Task<int> PutByPKAsync(string bankID, int paytypeID, int paytypeChannel, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", tm_, ConcatValues(values_, bankID, paytypeID, paytypeChannel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bankID, int paytypeID, int paytypeChannel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
	        };
			return Put(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string bankID, int paytypeID, int paytypeChannel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBankID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankID(string bankID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankID` = @BankID";
			var parameter_ = Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankIDAsync(string bankID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankID` = @BankID";
			var parameter_ = Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankID
		#region PutPaytypeID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaytypeID(int paytypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeID` = @PaytypeID";
			var parameter_ = Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaytypeIDAsync(int paytypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeID` = @PaytypeID";
			var parameter_ = Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaytypeID
		#region PutPaytypeChannel
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaytypeChannel(int paytypeChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeChannel` = @PaytypeChannel";
			var parameter_ = Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaytypeChannelAsync(int paytypeChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeChannel` = @PaytypeChannel";
			var parameter_ = Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaytypeChannel
		#region PutChannelName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelNameByPK(string bankID, int paytypeID, int paytypeChannel, string channelName, TransactionManager tm_ = null)
		{
			RepairPutChannelNameByPKData(bankID, paytypeID, paytypeChannel, channelName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChannelNameByPKAsync(string bankID, int paytypeID, int paytypeChannel, string channelName, TransactionManager tm_ = null)
		{
			RepairPutChannelNameByPKData(bankID, paytypeID, paytypeChannel, channelName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChannelNameByPKData(string bankID, int paytypeID, int paytypeChannel, string channelName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChannelName` = @ChannelName  WHERE `BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelName", channelName != null ? channelName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelName(string channelName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelName` = @ChannelName";
			var parameter_ = Database.CreateInParameter("@ChannelName", channelName != null ? channelName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChannelNameAsync(string channelName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelName` = @ChannelName";
			var parameter_ = Database.CreateInParameter("@ChannelName", channelName != null ? channelName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChannelName
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sb_bank_paytype_channelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BankID, item.PaytypeID, item.PaytypeChannel) == null)
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
		public async Task<bool> SetAsync(Sb_bank_paytype_channelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BankID, item.PaytypeID, item.PaytypeChannel) == null)
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sb_bank_paytype_channelEO GetByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bankID, paytypeID, paytypeChannel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		public async Task<Sb_bank_paytype_channelEO> GetByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bankID, paytypeID, paytypeChannel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		private void RepairGetByPKData(string bankID, int paytypeID, int paytypeChannel, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BankID（字段）
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankIDByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (string)GetScalar("`BankID`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		public async Task<string> GetBankIDByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`BankID`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaytypeID（字段）
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPaytypeIDByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PaytypeID`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		public async Task<int> GetPaytypeIDByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PaytypeID`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaytypeChannel（字段）
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPaytypeChannelByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PaytypeChannel`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		public async Task<int> GetPaytypeChannelByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PaytypeChannel`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChannelName（字段）
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetChannelNameByPK(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ChannelName`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		public async Task<string> GetChannelNameByPKAsync(string bankID, int paytypeID, int paytypeChannel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ChannelName`", "`BankID` = @BankID AND `PaytypeID` = @PaytypeID AND `PaytypeChannel` = @PaytypeChannel", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBankID
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID)
		{
			return GetByBankID(bankID, 0, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, int top_)
		{
			return GetByBankID(bankID, top_, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, int top_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, int top_, TransactionManager tm_)
		{
			return GetByBankID(bankID, top_, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, int top_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, string sort_)
		{
			return GetByBankID(bankID, 0, sort_, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, string sort_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, string sort_, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, sort_, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, string sort_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByBankID(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByBankIDAsync(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		#endregion // GetByBankID
		#region GetByPaytypeID
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID)
		{
			return GetByPaytypeID(paytypeID, 0, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, 0, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, int top_)
		{
			return GetByPaytypeID(paytypeID, top_, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, int top_)
		{
			return await GetByPaytypeIDAsync(paytypeID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, int top_, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, top_, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, int top_, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, string sort_)
		{
			return GetByPaytypeID(paytypeID, 0, sort_, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, string sort_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, string sort_, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, 0, sort_, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, string sort_, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeID(int paytypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeID` = @PaytypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeIDAsync(int paytypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeID` = @PaytypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		#endregion // GetByPaytypeID
		#region GetByPaytypeChannel
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel)
		{
			return GetByPaytypeChannel(paytypeChannel, 0, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, TransactionManager tm_)
		{
			return GetByPaytypeChannel(paytypeChannel, 0, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, TransactionManager tm_)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, int top_)
		{
			return GetByPaytypeChannel(paytypeChannel, top_, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, int top_)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, int top_, TransactionManager tm_)
		{
			return GetByPaytypeChannel(paytypeChannel, top_, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, int top_, TransactionManager tm_)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, string sort_)
		{
			return GetByPaytypeChannel(paytypeChannel, 0, sort_, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, string sort_)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, string sort_, TransactionManager tm_)
		{
			return GetByPaytypeChannel(paytypeChannel, 0, sort_, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, string sort_, TransactionManager tm_)
		{
			return await GetByPaytypeChannelAsync(paytypeChannel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeChannel（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeChannel">支付方式下的渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByPaytypeChannel(int paytypeChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeChannel` = @PaytypeChannel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByPaytypeChannelAsync(int paytypeChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeChannel` = @PaytypeChannel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeChannel", paytypeChannel, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		#endregion // GetByPaytypeChannel
		#region GetByChannelName
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName)
		{
			return GetByChannelName(channelName, 0, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName)
		{
			return await GetByChannelNameAsync(channelName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, TransactionManager tm_)
		{
			return GetByChannelName(channelName, 0, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, TransactionManager tm_)
		{
			return await GetByChannelNameAsync(channelName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, int top_)
		{
			return GetByChannelName(channelName, top_, string.Empty, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, int top_)
		{
			return await GetByChannelNameAsync(channelName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, int top_, TransactionManager tm_)
		{
			return GetByChannelName(channelName, top_, string.Empty, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, int top_, TransactionManager tm_)
		{
			return await GetByChannelNameAsync(channelName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, string sort_)
		{
			return GetByChannelName(channelName, 0, sort_, null);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, string sort_)
		{
			return await GetByChannelNameAsync(channelName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, string sort_, TransactionManager tm_)
		{
			return GetByChannelName(channelName, 0, sort_, tm_);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, string sort_, TransactionManager tm_)
		{
			return await GetByChannelNameAsync(channelName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChannelName（字段） 查询
		/// </summary>
		/// /// <param name = "channelName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sb_bank_paytype_channelEO> GetByChannelName(string channelName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(channelName != null ? "`ChannelName` = @ChannelName" : "`ChannelName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (channelName != null)
				paras_.Add(Database.CreateInParameter("@ChannelName", channelName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		public async Task<List<Sb_bank_paytype_channelEO>> GetByChannelNameAsync(string channelName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(channelName != null ? "`ChannelName` = @ChannelName" : "`ChannelName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (channelName != null)
				paras_.Add(Database.CreateInParameter("@ChannelName", channelName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sb_bank_paytype_channelEO.MapDataReader);
		}
		#endregion // GetByChannelName
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
