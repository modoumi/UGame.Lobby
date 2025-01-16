namespace UGame.Lobby.Service.Services.Home
{
    public class QueryInputIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 用户输入查询条件
        /// </summary>
        public string Input { get; set; }

        /// <summary>
        /// 起始页
        /// </summary>
        public int PageIndex { get; set; }


        /// <summary>
        /// 数据量大小
        /// </summary>
        public int PageSize { get; set; }
    }
}
