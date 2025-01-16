using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AiUo.Configuration;
namespace UGame.Lobby.Service;

public static class LobbyHostBuilderExtensions
{
    public static IHostBuilder UseLobbyServer(this IHostBuilder builder)
    {
        return builder;
    }
}
