using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.SCommon;
using UGame.Lobby.Service.Services.SCommon.Marquee;

namespace UGame.Lobby.Service.Caching.SCommon
{
    public class SCMarqueeDCache : RedisListClient<SCMarqueeDto>
    {
        public int EXPIRE_MINUTES = 30;
        public string OperatorId { get; private set; }
        public string LangId { get; private set; }
        public int MarqueeType { get; private set; }
        private SCMarqueeService marqueeService = new();
        private Sc_templMO _templMO = new();
        private Sc_templ_langMO _templLangMO = new();

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="langId">en,es,pt</param>
        /// <param name="marqueeType">0:文字类跑马灯，1:带图片跑马灯</param>
        public SCMarqueeDCache(string operatorId, string langId, int marqueeType)
        {
            OperatorId = operatorId;
            LangId = langId;
            MarqueeType = marqueeType != 0 && marqueeType != 1 ? 0 : marqueeType;
            RedisKey = GetProjectGroupRedisKey("Marquee", $"{OperatorId}|{MarqueeType}|{LangId}");
        }

        protected override async Task<CacheValue<IEnumerable<SCMarqueeDto>>> LoadAllValuesWhenRedisNotExistsAsync()
        {
            var marqueeConfig = LobbyDbCacheUtil.GetMarqueeConfig(OperatorId);
            var ret = new CacheValue<IEnumerable<SCMarqueeDto>>();
            var curTemplateLang = await marqueeService.GetTemplateLang(MarqueeType, LangId);
            if (curTemplateLang != null)
            {
                var dataCount = MarqueeType == 0 ? marqueeConfig.TextMaxNumber : marqueeConfig.PicMaxNumber;
                var dtoList = await marqueeService.GenerateFakeMarqueeDto(curTemplateLang, OperatorId, dataCount, MarqueeType);
                ret.Value = dtoList;
                ret.HasValue = dtoList != null && dtoList.Any();
            }

            Database.KeyExpire(RedisKey, TimeSpan.FromMinutes(EXPIRE_MINUTES));
            return ret;
        }

        /// <summary>
        /// 更新缓存
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task UpdateCache(SCMarqueeDto dto)
        {
            var marqueeConfig = LobbyDbCacheUtil.GetMarqueeConfig(OperatorId);
            var dataCount =  marqueeConfig.TextMaxNumber;
            if (MarqueeType == 1)
            {
                var picMarqueeApps = await marqueeService.GetMarqueePicApps(OperatorId);
                dataCount = picMarqueeApps.Count;
                var curDtoList = (await GetAllAsync()).ToList();
                var existAppDtoList = curDtoList.Where(d => d.AppId == dto.AppId).ToList();
                if (existAppDtoList.Any())
                {
                    foreach (var cdto in existAppDtoList)
                    {
                        await RemoveAsync(cdto);
                    }
                }
            }

            await LeftPushAsync(dto);
            if (await GetLengthAsync() > dataCount)
                await RightPopAsync();
        }
    }
}
