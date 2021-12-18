using OrchardCore.Logging;
//using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseNLogWeb();

builder.Services.AddOrchardCms();

var app = builder.Build();

app.UseOrchardCore();

app.Run();
