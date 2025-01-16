using UGame.Lobby.Repository.ing;
using System.Text.RegularExpressions;
using AiUo.Configuration;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using Xxyy.Common.Caching;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.SCommon.Marquee
{
    public class SCMarqueeService
    {
        L_appMO lappMo = new();
        S_appMO sappMo = new();
        S_operator_appMO operatorMo = new();
        Sc_templMO _templMO = new();
        Sc_templ_langMO _templLangMO = new();

        /// <summary>
        /// 通过模板生成真实轮播数据
        /// </summary>
        /// <param name="metaData"></param>
        /// <param name="template"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public async Task<SCMarqueeDto> GenerateMarqueeDto(MarqueeMetaModel metaData, Sc_templ_langEO template, string operatorId)
        {
            var ret = new SCMarqueeDto();
            if (metaData != null)
            {
                var operatorApp = DbCacheUtil.GetOperatorApp(operatorId, metaData.appId);
                ret.AppName = metaData.appName;
                ret.AppIcon = metaData.appIcon;
                ret.AppId = metaData.appId;
                ret.IsSupportBonus = operatorApp.UseBonus;
                ret.WinAmount = metaData.amount;

                string marqueeText = Regex.Replace(template.Content, "\\{(\\w+)\\}", (match) =>
                {
                    if (match.Success)
                    {
                        var key = match.Result("$1");
                        string val = string.Empty;

                        var propertyInfo = metaData.GetType().GetProperty(key);
                        if (propertyInfo != null)
                            val = Convert.ToString(propertyInfo.GetValue(metaData, null));//.ToString();
                        if (!string.IsNullOrWhiteSpace(val))
                        {
                            if ("mobile" == key)
                            {
                                if (Regex.IsMatch(val, "^\\d+$"))
                                {
                                    if (val.Length > 4)
                                    {
                                        val = val.Substring(0, 2) + "******" + val.Substring(val.Length - 4);
                                    }
                                }
                                else
                                {
                                    val = val.Length > 3 ? "******" + val.Substring(val.Length - 3) : val;
                                }
                                ret.UserNameOrMobile = val;
                            }
                            else if ("userName" == key)
                            {
                                if (Regex.IsMatch(val, "^\\d+$"))
                                {
                                    if (val.Length > 4)
                                    {
                                        val = val.Substring(0, 2) + "******" + val.Substring(val.Length - 4);
                                    }
                                }
                                else
                                {
                                    val = val.Length > 3 ? "******" + val.Substring(val.Length - 3) : val;
                                }
                                ret.UserNameOrMobile = val;
                            }
                            return val;
                        }
                        else
                        {
                            return match.Value;
                        }
                    }
                    return match.Value;
                });

                ret.MessageContent = marqueeText;
            }

            return ret;
        }

        /// <summary>
        /// 通过模板生成伪造轮播数据
        /// <param name="template"></param>
        /// <param name="operatorId"></param>
        /// <param name="dataCount">生成数量</param>
        /// <param name="marqueeType">0:文字轮播，1:带图的轮播</param>
        /// <param name="excludeAppIds">需要排除的游戏id</param>
        /// <returns></returns>
        public async Task<List<SCMarqueeDto>> GenerateFakeMarqueeDto(Sc_templ_langEO template, string operatorId, int dataCount, int marqueeType, List<string> excludeAppIds = null)
        {
            var ret = new List<SCMarqueeDto>();
            var marqueeConfig = LobbyDbCacheUtil.GetMarqueeConfig(operatorId);
            if (marqueeConfig != null)
            {
                var originalRandomApps = await sappMo.GetTopSortAsync("`Status`=1 and AppType=2", 20, "RAND() asc");//原始游戏app
                var randomApps = new List<S_operator_appEO>();//文字类轮播游戏app
                foreach (var _sapp in originalRandomApps)
                {
                    var _operApp = DbCacheUtil.GetOperatorApp(operatorId, _sapp.AppID, false);
                    if (_operApp != null)
                    {
                        randomApps.Add(_operApp);
                    }
                }

                if (marqueeType == 1)
                {
                    randomApps = await GetMarqueePicApps(operatorId, excludeAppIds);
                    dataCount = dataCount < randomApps.Count ? dataCount : randomApps.Count;//图片轮播时，缓存中每款游戏只有一条数据
                }

                if (dataCount > 0 && randomApps.Any())
                {
                    Random rand = new Random();
                    var secondaryRandomApps = new List<S_operator_appEO>();
                    var remainDataCount = dataCount;
                    var j = 0;
                    for (int i = 0; i < dataCount; i++)
                    {
                        j = j > randomApps.Count - 1 ? 0 : j;
                        var curOperApp = randomApps[j];
                        var metaData = GenerateFakeMarqueeMetaData(curOperApp, marqueeConfig);
                        if (metaData != null)
                        {
                            ret.Add(await GenerateMarqueeDto(metaData, template, operatorId));
                            remainDataCount--;
                            secondaryRandomApps.Add(curOperApp);
                        }
                        j++;
                    }

                    if (remainDataCount > 0 && secondaryRandomApps.Any())//不够数量时，再生成一次
                    {
                        j = 0;
                        for (int i = 0; i < remainDataCount; i++)
                        {
                            j = j > secondaryRandomApps.Count - 1 ? 0 : j;
                            var curOperApp = randomApps[j];
                            var metaData = GenerateFakeMarqueeMetaData(curOperApp, marqueeConfig);
                            if (metaData != null)
                            {
                                ret.Add(await GenerateMarqueeDto(metaData, template, operatorId));
                            }
                            j++;
                        }
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// 获取轮播模板
        /// </summary>
        /// <param name="marqueeType"></param>
        /// <param name="langId"></param>
        /// <returns></returns>
        public async Task<Sc_templ_langEO> GetTemplateLang(int marqueeType, string langId)
        {
            var curTemplate = (await _templMO.GetAsync("TemplateType=@templType", marqueeType)).First();
            if (curTemplate != null)
            {
                var curTemplateLang = (await _templLangMO.GetAsync("SCTemplateID=@templateId and LangID=@langId", curTemplate.SCTemplateID, langId)).First();
                return curTemplateLang;
            }
            return null;
        }

        /// <summary>
        /// 获取轮播图片的游戏app
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public async Task<List<S_operator_appEO>> GetMarqueePicApps(string operatorId, List<string> excludeAppIds = null)
        {
            var ret = new List<S_operator_appEO>();
            //var picRandomApps = await lappMo.GetTopSortAsync("MarqueeStatus=1", 20, "RAND() asc");//支持轮播的app
            var picRandomApps =
                await lappMo.GetSortAsync("MarqueeStatus=1 and MarqueeIcon!=''", "RAND() asc"); //支持轮播的app
            foreach (var _lapp in picRandomApps)
            {
                var _operApp = DbCacheUtil.GetOperatorApp(operatorId, _lapp.AppID, false);
                if (_operApp != null)
                {
                    ret.Add(_operApp);
                }
            }

            if (excludeAppIds != null && excludeAppIds.Any())
                ret = ret.Where(a => !excludeAppIds.Contains(a.AppID)).ToList();

            return ret;
        }

        /// <summary>
        /// 获取随机字符
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        private string GetRdmCode(int len)
        {
            string rndCode = string.Empty;
            var character = new char[] { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };
            Random rnd = new Random();
            for (int i = 0; i < len; i++)
            {
                rndCode += character[rnd.Next(character.Length)];
            }
            return rndCode;
        }

        /// <summary>
        /// 伪造轮播元数据
        /// </summary>
        /// <param name="operApp"></param>
        /// <param name="marqueeConfig"></param>
        /// <returns></returns>
        private MarqueeMetaModel GenerateFakeMarqueeMetaData(S_operator_appEO operApp, Sc_marquee_configEO marqueeConfig)
        {
            Random rand = new Random();
            var curSapp = DbCacheUtil.GetApp(operApp.AppID);
            var curLapp = LobbyDbCacheUtil.GetLApp(operApp.AppID);
            if (curSapp == null || curLapp == null) return null;
            var lobbyAppOptions = ConfigUtil.GetSection<LobbyOptionsSection>();
            var baseImageUrl = lobbyAppOptions.ImageBaseUrl;
            var metaData = new MarqueeMetaModel
            {
                appId = curSapp.AppID,
                appName = curSapp.AppName,
                userId = ObjectId.NewId(),
                userName = "******" + GetRdmCode(3),
                mobile = "55******" + rand.Next(1000, 9999),
                amount = rand.Next(100, 1000) * marqueeConfig.FakeWinMultiple,
                recDate = DateTime.UtcNow,
                appIcon = baseImageUrl + curLapp.MarqueeIcon
            };
            return metaData;
        }


    }
}
