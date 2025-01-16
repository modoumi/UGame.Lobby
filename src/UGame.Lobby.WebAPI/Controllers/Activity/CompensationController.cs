using UGame.Lobby.Service.Services.Activity.Compensation;
using UGame.Lobby.Service.Services.Activity.Compensation.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;

namespace UGame.Lobby.WebAPI.Controllers.Activity;

/// <summary>
/// 包赔活动
/// </summary>
[EnableCors()]
public class CompensationController : AiUoControllerBase
{
    private readonly CompensationService _compensationService = new();

    /// <summary>
    /// 获取用户包赔信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<CompensationDto> Load(CompensationIpo input)
    {
        input.UserId = base.UserId;
        return await _compensationService.LoadAsync(input);
    }

    /// <summary>
    /// 领取Bonus
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<CompensationRecevieDto> Recevie(CompensationRecevieIpo input)
    {
        input.UserId = base.UserId;
        return await _compensationService.RecevieAsync(input);
    }
}
