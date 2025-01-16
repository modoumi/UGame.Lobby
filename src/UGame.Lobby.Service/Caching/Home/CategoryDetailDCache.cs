using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;

namespace UGame.Lobby.Service.Caching.Home;

public class CategoryDetailDCache : RedisStringClient<List<CategoryDetailDto>>
{
    private const int EXPIRE_DAY = 1;

    private string OperatorId { get; set; }

    private string LangId { get; set; }

    private int CategoryId { get; set; }

    public CategoryDetailDCache(string operatorId, string langId, int categoryId)
    {
        this.OperatorId = operatorId;
        this.LangId = langId;
        this.CategoryId = categoryId;
        RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.LangId}|{this.CategoryId}");
    }

    protected override async Task<CacheValue<List<CategoryDetailDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<CategoryDetailDto>>();

        var items = await DbUtil.GetRepository<V_l_category_detailPO>().AsQueryable()
            .Where(d => d.ParentId == this.CategoryId && d.LangID.Equals(this.LangId) && d.OperatorID.Equals(this.OperatorId))
            .OrderBy(d => d.CategoryOrderNum)
            .OrderBy(d => d.CategoryID)
            .OrderBy(d => d.AppOrderNum)
            .ToListAsync();


        var value = new List<CategoryDetailDto>();
        foreach (var item in items)
        {
            //item.Template=1大图
            //item.Template=2小图
            //item.Template=3中图
            //item.Template=4平铺，取100条
            //item.Template=5显示6条数据
            //item.Template=6显示9条数据
            var size = 6 * 3;
            switch (item.Template)
            {
                case 2: size = 3 * 3; break;
                case 3: size = 5 * 3; break;
                case 4: size = 3 * 40; break;
                case 5: size = 3 * 6; break;
                case 6: size = 3 * 9; break;
            }

            if (value.Any() 
                && value.Last() != null 
                && value.Last().Apps != null 
                && value.Last().Apps.Count() >= size 
                && value.Last().CategoryID == item.CategoryID)
                continue;

            var detailApp = item.Map<AppDetailDto>();
            if (value.Count == 0 || value.Last().CategoryID != item.CategoryID)
            {
                value.Add(new CategoryDetailDto
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName,
                    Template = item.Template,
                    HasIcon = !string.IsNullOrWhiteSpace(item.CategoryIcon),
                    Icon = item.CategoryIcon,
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
    public async Task<CacheValue<List<CategoryDetailDto>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));
    }

}
