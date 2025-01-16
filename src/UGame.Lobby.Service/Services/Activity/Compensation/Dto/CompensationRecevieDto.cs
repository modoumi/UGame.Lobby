namespace UGame.Lobby.Service.Services.Activity.Compensation.Dto;

public class CompensationRecevieDto
{

    /// <summary>
    /// 是否领取成功
    /// </summary>
    public bool IsSuccess { get; set; } = false;

    /// <summary>
    /// 领取的bonus
    /// </summary>
    public decimal Bonus { get; set; } = 0;

    /// <summary>
    /// 提示信息
    /// </summary>
    public string Message { get; set; }

}
