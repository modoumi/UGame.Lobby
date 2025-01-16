
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Partners.Client;
using Xxyy.Partners.Model;

namespace UGame.Lobby.Service.Services.Init
{
    public class LobbyAppUrlIpo : LobbyBaseIpo, IMapTo<XxyyAppUrlIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDemo { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public string LobbyUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DepositUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object Meta { get; set; }

        public void MapTo(XxyyAppUrlIpo destination)
        {
            destination.Platform = 0;
        }
    }

    public class LobbyAppUrlDto : IMapFrom<AppUrlDto>
    {
        public string Status { get; set; }
        /// <summary>
        /// 应用呈现模式 0- url 1-content
        /// </summary>
        public int Mode { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public object Meta { get; set; }


        public void MapFrom(AppUrlDto source)
        {
        }
    }

}
