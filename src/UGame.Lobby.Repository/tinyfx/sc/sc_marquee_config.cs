/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:06
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
	/// 【表 sc_marquee_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_marquee_configEO : IRowMapper<Sc_marquee_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_marquee_configEO()
		{
			this.FakeWinMultiple = 1;
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
		/// 返奖的最小额度
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long WinMinAmount { get; set; }
		/// <summary>
		/// 文字滚动的最大数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int TextMaxNumber { get; set; }
		/// <summary>
		/// 图片滚动的最大数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int PicMaxNumber { get; set; }
		/// <summary>
		/// 返奖伪造多少倍
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FakeWinMultiple { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_marquee_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_marquee_configEO MapDataReader(IDataReader reader)
		{
		    Sc_marquee_configEO ret = new Sc_marquee_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.WinMinAmount = reader.ToInt64("WinMinAmount");
			ret.TextMaxNumber = reader.ToInt32("TextMaxNumber");
			ret.PicMaxNumber = reader.ToInt32("PicMaxNumber");
			ret.FakeWinMultiple = reader.ToInt32("FakeWinMultiple");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sc_marquee_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_marquee_configMO : MySqlTableMO<Sc_marquee_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_marquee_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_marquee_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_marquee_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_marquee_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_marquee_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_marquee_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_marquee_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `WinMinAmount`, `TextMaxNumber`, `PicMaxNumber`, `FakeWinMultiple`, `RecDate`) VALUE (@OperatorID, @WinMinAmount, @TextMaxNumber, @PicMaxNumber, @FakeWinMultiple, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WinMinAmount", item.WinMinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TextMaxNumber", item.TextMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@PicMaxNumber", item.PicMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@FakeWinMultiple", item.FakeWinMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_marquee_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_marquee_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_marquee_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `WinMinAmount`, `TextMaxNumber`, `PicMaxNumber`, `FakeWinMultiple`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}',{item.WinMinAmount},{item.TextMaxNumber},{item.PicMaxNumber},{item.FakeWinMultiple},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Sc_marquee_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_marquee_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByWinMinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinMinAmount(long winMinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinMinAmountData(winMinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinMinAmountAsync(long winMinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinMinAmountData(winMinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinMinAmountData(long winMinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinMinAmount` = @WinMinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinMinAmount
		#region RemoveByTextMaxNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTextMaxNumber(int textMaxNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByTextMaxNumberData(textMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTextMaxNumberAsync(int textMaxNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByTextMaxNumberData(textMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTextMaxNumberData(int textMaxNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TextMaxNumber` = @TextMaxNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveByTextMaxNumber
		#region RemoveByPicMaxNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPicMaxNumber(int picMaxNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByPicMaxNumberData(picMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPicMaxNumberAsync(int picMaxNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByPicMaxNumberData(picMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPicMaxNumberData(int picMaxNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PicMaxNumber` = @PicMaxNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveByPicMaxNumber
		#region RemoveByFakeWinMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFakeWinMultiple(int fakeWinMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByFakeWinMultipleData(fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFakeWinMultipleAsync(int fakeWinMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByFakeWinMultipleData(fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFakeWinMultipleData(int fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FakeWinMultiple` = @FakeWinMultiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32));
		}
		#endregion // RemoveByFakeWinMultiple
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
		public int Put(Sc_marquee_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_marquee_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_marquee_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `WinMinAmount` = @WinMinAmount, `TextMaxNumber` = @TextMaxNumber, `PicMaxNumber` = @PicMaxNumber, `FakeWinMultiple` = @FakeWinMultiple WHERE `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WinMinAmount", item.WinMinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TextMaxNumber", item.TextMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@PicMaxNumber", item.PicMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@FakeWinMultiple", item.FakeWinMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_marquee_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_marquee_configEO> items, TransactionManager tm_ = null)
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
		#region PutWinMinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinMinAmountByPK(string operatorID, long winMinAmount, TransactionManager tm_ = null)
		{
			RepairPutWinMinAmountByPKData(operatorID, winMinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinMinAmountByPKAsync(string operatorID, long winMinAmount, TransactionManager tm_ = null)
		{
			RepairPutWinMinAmountByPKData(operatorID, winMinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinMinAmountByPKData(string operatorID, long winMinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinMinAmount` = @WinMinAmount  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinMinAmount(long winMinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinMinAmount` = @WinMinAmount";
			var parameter_ = Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinMinAmountAsync(long winMinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinMinAmount` = @WinMinAmount";
			var parameter_ = Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinMinAmount
		#region PutTextMaxNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTextMaxNumberByPK(string operatorID, int textMaxNumber, TransactionManager tm_ = null)
		{
			RepairPutTextMaxNumberByPKData(operatorID, textMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTextMaxNumberByPKAsync(string operatorID, int textMaxNumber, TransactionManager tm_ = null)
		{
			RepairPutTextMaxNumberByPKData(operatorID, textMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTextMaxNumberByPKData(string operatorID, int textMaxNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TextMaxNumber` = @TextMaxNumber  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTextMaxNumber(int textMaxNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TextMaxNumber` = @TextMaxNumber";
			var parameter_ = Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTextMaxNumberAsync(int textMaxNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TextMaxNumber` = @TextMaxNumber";
			var parameter_ = Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTextMaxNumber
		#region PutPicMaxNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPicMaxNumberByPK(string operatorID, int picMaxNumber, TransactionManager tm_ = null)
		{
			RepairPutPicMaxNumberByPKData(operatorID, picMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPicMaxNumberByPKAsync(string operatorID, int picMaxNumber, TransactionManager tm_ = null)
		{
			RepairPutPicMaxNumberByPKData(operatorID, picMaxNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPicMaxNumberByPKData(string operatorID, int picMaxNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PicMaxNumber` = @PicMaxNumber  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPicMaxNumber(int picMaxNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PicMaxNumber` = @PicMaxNumber";
			var parameter_ = Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPicMaxNumberAsync(int picMaxNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PicMaxNumber` = @PicMaxNumber";
			var parameter_ = Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPicMaxNumber
		#region PutFakeWinMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFakeWinMultipleByPK(string operatorID, int fakeWinMultiple, TransactionManager tm_ = null)
		{
			RepairPutFakeWinMultipleByPKData(operatorID, fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFakeWinMultipleByPKAsync(string operatorID, int fakeWinMultiple, TransactionManager tm_ = null)
		{
			RepairPutFakeWinMultipleByPKData(operatorID, fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFakeWinMultipleByPKData(string operatorID, int fakeWinMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FakeWinMultiple` = @FakeWinMultiple  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFakeWinMultiple(int fakeWinMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FakeWinMultiple` = @FakeWinMultiple";
			var parameter_ = Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFakeWinMultipleAsync(int fakeWinMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FakeWinMultiple` = @FakeWinMultiple";
			var parameter_ = Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFakeWinMultiple
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
		public bool Set(Sc_marquee_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sc_marquee_configEO item, TransactionManager tm = null)
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
		public Sc_marquee_configEO GetByPK(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<Sc_marquee_configEO> GetByPKAsync(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
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
		/// 按主键查询 WinMinAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinMinAmountByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinMinAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetWinMinAmountByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinMinAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TextMaxNumber（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTextMaxNumberByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TextMaxNumber`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetTextMaxNumberByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TextMaxNumber`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PicMaxNumber（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPicMaxNumberByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PicMaxNumber`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetPicMaxNumberByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PicMaxNumber`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FakeWinMultiple（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFakeWinMultipleByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FakeWinMultiple`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFakeWinMultipleByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FakeWinMultiple`", "`OperatorID` = @OperatorID", paras_, tm_);
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
		#region GetByWinMinAmount
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount)
		{
			return GetByWinMinAmount(winMinAmount, 0, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount)
		{
			return await GetByWinMinAmountAsync(winMinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, TransactionManager tm_)
		{
			return GetByWinMinAmount(winMinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, TransactionManager tm_)
		{
			return await GetByWinMinAmountAsync(winMinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, int top_)
		{
			return GetByWinMinAmount(winMinAmount, top_, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, int top_)
		{
			return await GetByWinMinAmountAsync(winMinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, int top_, TransactionManager tm_)
		{
			return GetByWinMinAmount(winMinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinMinAmountAsync(winMinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, string sort_)
		{
			return GetByWinMinAmount(winMinAmount, 0, sort_, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, string sort_)
		{
			return await GetByWinMinAmountAsync(winMinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinMinAmount(winMinAmount, 0, sort_, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinMinAmountAsync(winMinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinMinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winMinAmount">返奖的最小额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByWinMinAmount(long winMinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinMinAmount` = @WinMinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<List<Sc_marquee_configEO>> GetByWinMinAmountAsync(long winMinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinMinAmount` = @WinMinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinMinAmount", winMinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		#endregion // GetByWinMinAmount
		#region GetByTextMaxNumber
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber)
		{
			return GetByTextMaxNumber(textMaxNumber, 0, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, TransactionManager tm_)
		{
			return GetByTextMaxNumber(textMaxNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, TransactionManager tm_)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, int top_)
		{
			return GetByTextMaxNumber(textMaxNumber, top_, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, int top_)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, int top_, TransactionManager tm_)
		{
			return GetByTextMaxNumber(textMaxNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, int top_, TransactionManager tm_)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, string sort_)
		{
			return GetByTextMaxNumber(textMaxNumber, 0, sort_, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, string sort_)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, string sort_, TransactionManager tm_)
		{
			return GetByTextMaxNumber(textMaxNumber, 0, sort_, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, string sort_, TransactionManager tm_)
		{
			return await GetByTextMaxNumberAsync(textMaxNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TextMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "textMaxNumber">文字滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByTextMaxNumber(int textMaxNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TextMaxNumber` = @TextMaxNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<List<Sc_marquee_configEO>> GetByTextMaxNumberAsync(int textMaxNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TextMaxNumber` = @TextMaxNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TextMaxNumber", textMaxNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		#endregion // GetByTextMaxNumber
		#region GetByPicMaxNumber
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber)
		{
			return GetByPicMaxNumber(picMaxNumber, 0, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, TransactionManager tm_)
		{
			return GetByPicMaxNumber(picMaxNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, TransactionManager tm_)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, int top_)
		{
			return GetByPicMaxNumber(picMaxNumber, top_, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, int top_)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, int top_, TransactionManager tm_)
		{
			return GetByPicMaxNumber(picMaxNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, int top_, TransactionManager tm_)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, string sort_)
		{
			return GetByPicMaxNumber(picMaxNumber, 0, sort_, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, string sort_)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, string sort_, TransactionManager tm_)
		{
			return GetByPicMaxNumber(picMaxNumber, 0, sort_, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, string sort_, TransactionManager tm_)
		{
			return await GetByPicMaxNumberAsync(picMaxNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PicMaxNumber（字段） 查询
		/// </summary>
		/// /// <param name = "picMaxNumber">图片滚动的最大数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByPicMaxNumber(int picMaxNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PicMaxNumber` = @PicMaxNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<List<Sc_marquee_configEO>> GetByPicMaxNumberAsync(int picMaxNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PicMaxNumber` = @PicMaxNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PicMaxNumber", picMaxNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		#endregion // GetByPicMaxNumber
		#region GetByFakeWinMultiple
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, 0, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, TransactionManager tm_)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, TransactionManager tm_)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, int top_)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, top_, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, int top_)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, int top_, TransactionManager tm_)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, int top_, TransactionManager tm_)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, string sort_)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, 0, sort_, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, string sort_)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, string sort_, TransactionManager tm_)
		{
			return GetByFakeWinMultiple(fakeWinMultiple, 0, sort_, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, string sort_, TransactionManager tm_)
		{
			return await GetByFakeWinMultipleAsync(fakeWinMultiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FakeWinMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "fakeWinMultiple">返奖伪造多少倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByFakeWinMultiple(int fakeWinMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FakeWinMultiple` = @FakeWinMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<List<Sc_marquee_configEO>> GetByFakeWinMultipleAsync(int fakeWinMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FakeWinMultiple` = @FakeWinMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FakeWinMultiple", fakeWinMultiple, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		#endregion // GetByFakeWinMultiple
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sc_marquee_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		public async Task<List<Sc_marquee_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marquee_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
