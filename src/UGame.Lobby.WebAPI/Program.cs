using UGame.Lobby.Service;
using System.Reflection;

namespace UGame.Lobby.WebAPI;

/// <summary>
/// 
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var builder = AspNetHost.CreateBuilder();
        // Add services to the container.
        builder.AddAspNetEx();
        //builder.Services.AddRazorPages();
        builder.Host.UseLobbyServer();
        //builder.Services.AddLobbyOptions();
        //builder.Host.UseRabbitMQEx();

        builder.Services.AddMediatR(svcConfig =>
        {
            svcConfig.RegisterServicesFromAssemblies(typeof(Program).Assembly, Assembly.Load("UGame.Lobby.Service"));
        });
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        app.UseAspNetEx();
        //app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}