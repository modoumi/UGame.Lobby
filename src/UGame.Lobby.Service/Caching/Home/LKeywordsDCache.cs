using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Home
{
    public class LKeywordsDCache : RedisStringClient<List<KeywordsDto>>
    {
        private const int EXPIRE_MINUTES = 60;

        private string OperatorId { get; set; }

        private string LangId { get; set; }

        public LKeywordsDCache(string operatorId, string langId)
        {
            this.OperatorId = operatorId;
            this.LangId = langId;
            RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.LangId}");
        }
        protected override async Task<CacheValue<List<KeywordsDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<KeywordsDto>>();

            var sql = @$"select 
	                        kc.KCID,
	                        kc.KCName,
	                        kc.OrderNum as KCOrderNum,
	                        kc.OperatorId as KCOperatorId,
	                        kw.OperatorID as KWOperatorId,
	                        kw.KeywordID,
	                        kw.OperatorID,
	                        kw.LangID,
	                        kw.Title,
	                        kw.OrderNum as kwOrderNum
                        from l_keyword_category as kc
                        left join l_keyword as kw
                        on kc.KCID = kw.KCID and kc.OperatorID = kw.OperatorID
                        where kc.OperatorId = @kcOperatorId
                        and kw.OperatorID = @kwOperatorId
                        and kw.LangID = @kwLangID
                        and kc.LangID = @kcLangID
                        and kw.status = 1;";

            var dbData = await DbSink.MainDb.ExecSqlListAsync<KeywordEntity>(sql, this.OperatorId, this.OperatorId, this.LangId, this.LangId);

            var value = new List<KeywordsDto>();

            if (dbData.Any())
            {
                foreach (var item in dbData)
                {
                    if (value.Count > 0 && value.Last().KCId == item.KCID)
                        value.Last().Keywords.Add(GetItem(item));
                    else
                        value.Add(new KeywordsDto
                        {
                            KCId = item.KCID,
                            KCName = item.KCName,
                            Keywords = new List<KeywordsItem> { GetItem(item) }
                        });
                }

                KeywordsItem GetItem(KeywordEntity eo)
                {
                    return new KeywordsItem
                    {
                        KeywordId = eo.KeywordId,
                        Title = eo.Title,
                    };
                }
            }

            ret.Value = value;
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<KeywordsDto>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }

    }

    public class KeywordEntity
    { 
        /// <summary>
        /// 关键字分类id
        /// </summary>
        public int KCID { get; set; }
        /// <summary>
        /// 关键字分类名称
        /// </summary>
        public string KCName { get; set; }
        /// <summary>
        /// 关键字分类排序
        /// </summary>
        public int KCOrderNum { get; set; }
        /// <summary>
        /// 关键字分类对应的operatorId
        /// </summary>
        public string KCOperatorId { get; set; }
        /// <summary>
        /// 关键字对应的operatorId
        /// </summary>
        public string KWOperatorId { get; set; }
        /// <summary>
        /// 关键字id
        /// </summary>
        public int KeywordId { get; set; }
        /// <summary>
        /// 关键字语言编码
        /// </summary>
        public string LangId { get; set; }
        /// <summary>
        /// 关键字名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 关键字排序
        /// </summary>
        public int KWOrderNum { get; set; }
    }

}
