using AiUo.Configuration;

namespace UGame.Lobby.Service;

public class LobbyOptionsSection : ConfigSection
{
    public override string SectionName => "LobbyOptions";
    /// <summary>
    /// 优先级：环境变量ENV_MyGameRandomAppNumber > 配置文件
    /// </summary>
    public string MyGameRandomAppNumber { get; set; }

    /// <summary>
    /// 优先级：环境变量ENV_ImageBaseUrl > 配置文件
    /// </summary>
    public string ImageBaseUrl { get; set; }

    public string MessageImgUrl { get; set; }

}
