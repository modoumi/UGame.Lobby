using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home;

public class QueryKeywordIpo : LobbyBaseIpo
{
    /// <summary>
    /// 关键字Id
    /// </summary>
    [RequiredEx("", "KeywordID cannot be empty.")]
    public string KeywordID { get; set; }
}

public class QueryByKeywordIpo : LobbyBaseIpo
{
    /// <summary>
    /// 关键字Id
    /// </summary>
    [RequiredEx("", "Keyword cannot be empty.")]
    public string Keyword { get; set; }
}
