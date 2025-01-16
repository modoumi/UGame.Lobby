﻿using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using AiUo;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Home;

public class BankyConfigDCache : RedisStringClient<Sa_banky_configPO>
{
    private const int EXPIRE_DAY = 1;//缓存有效期

    public string OperatorId { get; set; }

    public BankyConfigDCache(string operatorId)
    {
        if (string.IsNullOrEmpty(operatorId))
            throw new CustomException("BankyConfigDCache:UserId不能为空");

        OperatorId = operatorId;
        RedisKey = GetProjectGroupRedisKey("BankyProtect", $"{OperatorId}");
    }

    protected override async Task<CacheValue<Sa_banky_configPO>> LoadValueWhenRedisNotExistsAsync()
    {
        var value = await DbUtil.GetRepository<Sa_banky_configPO>().AsQueryable()
            .Where(_ => _.OperatorID == OperatorId && _.Status == 1)
            .FirstAsync();

        var ret = new CacheValue<Sa_banky_configPO>
        {
            HasValue = value != null,
            Value = value ?? new Sa_banky_configPO()
        };
        return ret;
    }

    /// <summary>
    /// 加载缓存
    /// 如果不存在调用LoadValueWhenRedisNotExistsAsync
    /// </summary>
    /// <returns></returns>
    public async Task<Sa_banky_configPO> GetAsync()
    {
        var cache = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));

        if (cache.HasValue) return cache.Value;

        return new Sa_banky_configPO();
    }

    /// <summary>
    /// 强制加载
    /// enforce=true
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_DAY));
    }
}
