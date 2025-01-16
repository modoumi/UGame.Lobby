using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using SqlSugar;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;

namespace UGame.Lobby.Service.Caching.Home;

public class TagDetailDCache : RedisStringClient<List<TagDetailDto>>
{
    private const int EXPIRE_DAY = 1;

    private string OperatorId { get; set; }

    private string LangId { get; set; }

    private int TagCode { get; set; }

    public TagDetailDCache(string operatorId, string langId, int tagCode)
    {
        OperatorId = operatorId;
        LangId = langId;
        TagCode = tagCode;
        RedisKey = GetProjectRedisKey($"{OperatorId}|{LangId}|{TagCode}");
    }

    protected override async Task<CacheValue<List<TagDetailDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<TagDetailDto>>();

        var items = await DbUtil.GetRepository<L_tagPO>().AsQueryable()
            .InnerJoin<L_tag_appPO>((tag, tagApp) => (tag.TagCode == tagApp.TagCode)&&(tag.OperatorID == tagApp.OperatorID))
            .InnerJoin<L_appPO>((tag, tagApp, app) => (tagApp.AppID == app.AppID))
            .WhereIF(TagCode == (int)TagCodeNum.All, tag => tag.LevelNum == 0 && (tag.TagType == (int)TagTypeEnum.Game || tag.TagType == (int)TagTypeEnum.Provedor))
            .WhereIF(TagCode != (int)TagCodeNum.All, tag => tag.TagCode == TagCode)
            .Where(tag => tag.LangID.Equals(this.LangId) && tag.OperatorID.Equals(this.OperatorId))
            .Select((tag, tagApp, app) => new TagAppDto
            {
                OperatorId = tag.OperatorID,
                TagCode = tag.TagCode,
                Name = tag.Name,
                LangID = tag.LangID,
                TagType = tag.TagType,
                LevelNum = tag.LevelNum,
                LevelOrderNum = tag.LevelOrderNum,
                OrderNum = tag.OrderNum,
                TagIcon = tag.TagIcon,
                Template = tag.Template,
                TagUrl = tag.TagUrl,
                AppId = app.AppID,
                SmallIcon = app.SmallIcon,
                MiddleIcon = app.MiddleIcon,
                BigIcon = app.BigIcon,
                Flag = app.Flag,
                AppSequence = tagApp.OrderNum
            })
            .OrderBy(tag => tag.OrderNum)
            .ToListAsync();

        var value = new List<TagDetailDto>();
        foreach (var item in items)
        {
            var size = 10000;

            if (value.Any() && value.Last() != null && value.Last().Apps != null
                && value.Last().Apps.Count >= size && value.Last().TagCode == item.TagCode)
                continue;

            var detailApp = item.Map<AppDetailDto>();
            if (value.Count == 0 || value.Last().TagCode != item.TagCode)
            {
                value.Add(new TagDetailDto
                {
                    TagCode = item.TagCode,
                    TagName = item.Name,
                    Template = item.Template,
                    HasIcon = !string.IsNullOrWhiteSpace(item.TagIcon),
                    Icon = item.TagIcon,
                    OrderNum = item.OrderNum,
                    TagType = item.TagType,
                    Apps = new List<AppDetailDto> { detailApp }
                });
            }
            else
            {
                value.Last().Apps.Add(detailApp);
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
    public async Task<CacheValue<List<TagDetailDto>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));
    }

}
