using Serilog;
using TinyFx;
using TinyFx.Logging;

var builder = AspNetHost.CreateBuilder();

// Add services to the container.
builder.AddAspNetEx(AspNetType.Api);

var app = builder.Build();
// Configure the HTTP request pipeline.
//app.UseTinyFx();
//app.UseTinyFxEx();
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();