using System.ComponentModel;

namespace UGame.Lobby.Service.Services.Activity.Compensation.Dto
{
    public enum CompensationStatus
    {

        [Description("不可领取")]
        NoAllow = 0,

        [Description("可领取")]
        Allow = 1,

        [Description("已领取")]
        Recived = 2
    }
}
