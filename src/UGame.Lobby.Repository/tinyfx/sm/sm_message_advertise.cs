/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-06-08 16: 39:58
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
	/// 【表 sm_message_advertise 的实体类】
	/// </summary>
	[DataContract]
	public class Sm_message_advertiseEO : IRowMapper<Sm_message_advertiseEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sm_message_advertiseEO()
		{
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalAdvertiseID;
		/// <summary>
		/// 【数据库中的原始主键 AdvertiseID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAdvertiseID
		{
			get { return _originalAdvertiseID; }
			set { HasOriginal = true; _originalAdvertiseID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AdvertiseID", AdvertiseID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 编号
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AdvertiseID { get; set; }
		/// <summary>
		/// 图片
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ImgURL { get; set; }
		/// <summary>
		/// 跳转链接
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Link { get; set; }
		/// <summary>
		/// 是否已经删除
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int? State { get; set; }
		/// <summary>
		/// 
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime? RecDate { get; set; }
		/// <summary>
		/// 
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime? UpdateTime { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sm_message_advertiseEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sm_message_advertiseEO MapDataReader(IDataReader reader)
		{
		    Sm_message_advertiseEO ret = new Sm_message_advertiseEO();
			ret.AdvertiseID = reader.ToString("AdvertiseID");
			ret.OriginalAdvertiseID = ret.AdvertiseID;
			ret.ImgURL = reader.ToString("ImgURL");
			ret.Link = reader.ToString("Link");
			ret.State = reader.ToInt32N("State");
			ret.RecDate = reader.ToDateTimeN("RecDate");
			ret.UpdateTime = reader.ToDateTimeN("UpdateTime");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sm_message_advertise 的操作类】
	/// </summary>
	public class Sm_message_advertiseMO : MySqlTableMO<Sm_message_advertiseEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sm_message_advertise`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sm_message_advertiseMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sm_message_advertiseMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sm_message_advertiseMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sm_message_advertiseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sm_message_advertiseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sm_message_advertiseEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AdvertiseID`, `ImgURL`, `Link`, `State`, `RecDate`, `UpdateTime`) VALUE (@AdvertiseID, @ImgURL, @Link, @State, @RecDate, @UpdateTime);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", item.AdvertiseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImgURL", item.ImgURL != null ? item.ImgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Link", item.Link != null ? item.Link : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@State", item.State.HasValue ? item.State.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime.HasValue ? item.UpdateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sm_message_advertiseEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sm_message_advertiseEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sm_message_advertiseEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AdvertiseID`, `ImgURL`, `Link`, `State`, `RecDate`, `UpdateTime`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AdvertiseID}','{item.ImgURL}','{item.Link}',{item.State?.ToString()??null},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string advertiseID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(advertiseID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(advertiseID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string advertiseID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sm_message_advertiseEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AdvertiseID, tm_);
		}
		public async Task<int> RemoveAsync(Sm_message_advertiseEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AdvertiseID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByImgURL
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImgURL(string imgURL, TransactionManager tm_ = null)
		{
			RepairRemoveByImgURLData(imgURL, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImgURLAsync(string imgURL, TransactionManager tm_ = null)
		{
			RepairRemoveByImgURLData(imgURL, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImgURLData(string imgURL, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImgURL
		#region RemoveByLink
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLink(string link, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkData(link, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkAsync(string link, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkData(link, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkData(string link, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (link != null ? "`Link` = @Link" : "`Link` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (link != null)
				paras_.Add(Database.CreateInParameter("@Link", link, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLink
		#region RemoveByState
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByState(int? state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStateAsync(int? state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStateData(int? state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (state.HasValue ? "`State` = @State" : "`State` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (state.HasValue)
				paras_.Add(Database.CreateInParameter("@State", state.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByState
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime? updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
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
		public int Put(Sm_message_advertiseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sm_message_advertiseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sm_message_advertiseEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AdvertiseID` = @AdvertiseID, `ImgURL` = @ImgURL, `Link` = @Link, `State` = @State WHERE `AdvertiseID` = @AdvertiseID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", item.AdvertiseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImgURL", item.ImgURL != null ? item.ImgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Link", item.Link != null ? item.Link : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@State", item.State.HasValue ? item.State.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@AdvertiseID_Original", item.HasOriginal ? item.OriginalAdvertiseID : item.AdvertiseID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sm_message_advertiseEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sm_message_advertiseEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "advertiseID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string advertiseID, string set_, params object[] values_)
		{
			return Put(set_, "`AdvertiseID` = @AdvertiseID", ConcatValues(values_, advertiseID));
		}
		public async Task<int> PutByPKAsync(string advertiseID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AdvertiseID` = @AdvertiseID", ConcatValues(values_, advertiseID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string advertiseID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AdvertiseID` = @AdvertiseID", tm_, ConcatValues(values_, advertiseID));
		}
		public async Task<int> PutByPKAsync(string advertiseID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AdvertiseID` = @AdvertiseID", tm_, ConcatValues(values_, advertiseID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string advertiseID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AdvertiseID` = @AdvertiseID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string advertiseID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AdvertiseID` = @AdvertiseID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutImgURL
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// /// <param name = "imgURL">图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImgURLByPK(string advertiseID, string imgURL, TransactionManager tm_ = null)
		{
			RepairPutImgURLByPKData(advertiseID, imgURL, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImgURLByPKAsync(string advertiseID, string imgURL, TransactionManager tm_ = null)
		{
			RepairPutImgURLByPKData(advertiseID, imgURL, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImgURLByPKData(string advertiseID, string imgURL, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL  WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImgURL(string imgURL, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL";
			var parameter_ = Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImgURLAsync(string imgURL, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL";
			var parameter_ = Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImgURL
		#region PutLink
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// /// <param name = "link">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkByPK(string advertiseID, string link, TransactionManager tm_ = null)
		{
			RepairPutLinkByPKData(advertiseID, link, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkByPKAsync(string advertiseID, string link, TransactionManager tm_ = null)
		{
			RepairPutLinkByPKData(advertiseID, link, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkByPKData(string advertiseID, string link, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Link` = @Link  WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Link", link != null ? link : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLink(string link, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Link` = @Link";
			var parameter_ = Database.CreateInParameter("@Link", link != null ? link : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkAsync(string link, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Link` = @Link";
			var parameter_ = Database.CreateInParameter("@Link", link != null ? link : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLink
		#region PutState
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStateByPK(string advertiseID, int? state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(advertiseID, state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStateByPKAsync(string advertiseID, int? state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(advertiseID, state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStateByPKData(string advertiseID, int? state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `State` = @State  WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@State", state.HasValue ? state.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutState(int? state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state.HasValue ? state.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStateAsync(int? state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state.HasValue ? state.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutState
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// /// <param name = "recDate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string advertiseID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(advertiseID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string advertiseID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(advertiseID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string advertiseID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// /// <param name = "updateTime"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string advertiseID, DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(advertiseID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string advertiseID, DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(advertiseID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string advertiseID, DateTime? updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `AdvertiseID` = @AdvertiseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime? updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sm_message_advertiseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AdvertiseID) == null)
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
		public async Task<bool> SetAsync(Sm_message_advertiseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AdvertiseID) == null)
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
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sm_message_advertiseEO GetByPK(string advertiseID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(advertiseID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<Sm_message_advertiseEO> GetByPKAsync(string advertiseID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(advertiseID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		private void RepairGetByPKData(string advertiseID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
		{
			sql_ = BuildSelectSQL("`AdvertiseID` = @AdvertiseID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ImgURL（字段）
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImgURLByPK(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ImgURL`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		public async Task<string> GetImgURLByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ImgURL`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Link（字段）
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkByPK(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Link`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		public async Task<string> GetLinkByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Link`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 State（字段）
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetStateByPK(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`State`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		public async Task<int?> GetStateByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`State`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RecDate`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "advertiseID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetUpdateTimeByPK(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`UpdateTime`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		public async Task<DateTime?> GetUpdateTimeByPKAsync(string advertiseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdvertiseID", advertiseID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`UpdateTime`", "`AdvertiseID` = @AdvertiseID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByImgURL
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL)
		{
			return GetByImgURL(imgURL, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL)
		{
			return await GetByImgURLAsync(imgURL, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, int top_)
		{
			return GetByImgURL(imgURL, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, int top_)
		{
			return await GetByImgURLAsync(imgURL, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, int top_, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, int top_, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, string sort_)
		{
			return GetByImgURL(imgURL, 0, sort_, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, string sort_)
		{
			return await GetByImgURLAsync(imgURL, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, string sort_, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, string sort_, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">图片</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByImgURL(string imgURL, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByImgURLAsync(string imgURL, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		#endregion // GetByImgURL
		#region GetByLink
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link)
		{
			return GetByLink(link, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link)
		{
			return await GetByLinkAsync(link, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, TransactionManager tm_)
		{
			return GetByLink(link, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, TransactionManager tm_)
		{
			return await GetByLinkAsync(link, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, int top_)
		{
			return GetByLink(link, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, int top_)
		{
			return await GetByLinkAsync(link, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, int top_, TransactionManager tm_)
		{
			return GetByLink(link, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, int top_, TransactionManager tm_)
		{
			return await GetByLinkAsync(link, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, string sort_)
		{
			return GetByLink(link, 0, sort_, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, string sort_)
		{
			return await GetByLinkAsync(link, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, string sort_, TransactionManager tm_)
		{
			return GetByLink(link, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, string sort_, TransactionManager tm_)
		{
			return await GetByLinkAsync(link, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Link（字段） 查询
		/// </summary>
		/// /// <param name = "link">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByLink(string link, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(link != null ? "`Link` = @Link" : "`Link` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (link != null)
				paras_.Add(Database.CreateInParameter("@Link", link, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByLinkAsync(string link, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(link != null ? "`Link` = @Link" : "`Link` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (link != null)
				paras_.Add(Database.CreateInParameter("@Link", link, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		#endregion // GetByLink
		#region GetByState
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state)
		{
			return GetByState(state, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state)
		{
			return await GetByStateAsync(state, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, TransactionManager tm_)
		{
			return GetByState(state, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, int top_)
		{
			return GetByState(state, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, int top_)
		{
			return await GetByStateAsync(state, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, int top_, TransactionManager tm_)
		{
			return GetByState(state, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, int top_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, string sort_)
		{
			return GetByState(state, 0, sort_, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, string sort_)
		{
			return await GetByStateAsync(state, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, string sort_, TransactionManager tm_)
		{
			return GetByState(state, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, string sort_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否已经删除</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByState(int? state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(state.HasValue ? "`State` = @State" : "`State` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (state.HasValue)
				paras_.Add(Database.CreateInParameter("@State", state.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByStateAsync(int? state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(state.HasValue ? "`State` = @State" : "`State` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (state.HasValue)
				paras_.Add(Database.CreateInParameter("@State", state.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		#endregion // GetByState
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, string sort_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_advertiseEO> GetByUpdateTime(DateTime? updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		public async Task<List<Sm_message_advertiseEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_advertiseEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
