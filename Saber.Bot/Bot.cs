using System.Diagnostics;
using System.Net.Http.Headers;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.DependencyInjection;
using Saber.Common;
using Saber.Database;
using System.Web;
using RestSharp;
using System.Reflection;
using Saber.Bot.Core.Handlers;
using Saber.Common.Services;
using Saber.Database.Providers;
using YoutubeDLSharp.Options;
using Saber.Common.AppSettings;
using Microsoft.Extensions.Configuration;
using Saber.Bot.Core;
using Microsoft.EntityFrameworkCore;
using Betalgo.Ranul.OpenAI.Extensions;
using Betalgo.Ranul.OpenAI.Interfaces;
using Saber.Common.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using NetCord;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using NetCord.Hosting.Services.Commands;
using NetCord.Rest;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;
using NetCord.Services.Commands;

var builder = Host.CreateApplicationBuilder(args);
var config = new Config();

builder.Services
    .AddDiscordGateway(x =>
    {
        x.Token = config["DiscordToken"];
        x.Intents = GatewayIntents.All;
        x.Presence = new PresenceProperties(UserStatusType.Online)
        {
            Activities = new[]
            {
                new UserActivityProperties("Gaming", UserActivityType.Playing)
            }
        };
    })
    .AddApplicationCommands()
    .AddSingleton<CommandService<CommandContext>>()
    .AddGatewayEventHandlers(typeof(Program).Assembly);

var googleConfig = new BaseClientService.Initializer()
{
    ApiKey = config["GoogleApiKey"],
    ApplicationName = "SaberBot"
};

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59");

builder.Services
    .AddSingleton(config)
    .AddSingleton<IConfiguration>(config)
    .AddDbContext<Db>(options => options.UseSqlServer(config["Database:ConnectionString"]), ServiceLifetime.Transient)
    .AddSingleton<ILogger, LoggerService>()
    .AddTransient<UserProfileProvider>()
    .AddTransient<GuildProvider>()
    .AddSingleton(httpClient)
    .AddSingleton(googleConfig)
    .AddScoped<YouTubeService>()
    .AddSingleton<AudioService>()
    .AddSingleton<YoutubeDlService>()
    .AddSingleton<FileUploaderService>()
    //.AddSingleton<OneLinerService>()
    .AddSingleton<WarframeService>()
    .AddTransient<ItemService>();

builder.Services.AddOpenAIService(s => { s.ApiKey = config["OpenAI:ApiKey"]; });
builder.Services.AddSingleton<OpenAiService>();

builder.Services
    .AddSingleton<IChatBot>(x => x.GetRequiredService<OpenAiService>())
    .AddSingleton<IImageGen>(x => x.GetRequiredService<OpenAiService>())
    .AddSingleton<ISummaryService, AiSummariseService>();

var host = builder.Build();

var client = host.Services.GetRequiredService<GatewayClient>();
var logger = host.Services.GetRequiredService<ILogger>();

client.Log += m => logger.LogAsync(m); 

host.AddModules(typeof(Program).Assembly);
host.UseGatewayEventHandlers();

var oldTempFiles = config.TempDir
    .GetFiles("*", SearchOption.TopDirectoryOnly)
    .Where(x => x.LastAccessTime < DateTime.Now.AddDays(-14));

foreach (var file in oldTempFiles)
    file.Delete();

Console.WriteLine("__________        __    .__                                    .___      ._.\n\\______   \\ _____/  |_  |__| ______ _______   ____ _____     __| _/__.__.| |\n |    |  _//  _ \\   __\\ |  |/  ___/ \\_  __ \\_/ __ \\\\__  \\   / __ <   |  || |\n |    |   (  <_> )  |   |  |\\___ \\   |  | \\/\\  ___/ / __ \\_/ /_/ |\\___  | \\|\n |______  /\\____/|__|   |__/____  >  |__|    \\___  >____  /\\____ |/ ____| __\n        \\/                      \\/               \\/     \\/      \\/\\/      \\/");

await host.RunAsync();