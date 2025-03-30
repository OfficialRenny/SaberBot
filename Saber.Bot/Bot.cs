using Betalgo.Ranul.OpenAI.Extensions;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCord;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Services.ApplicationCommands;
using NetCord.Services.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;
using Saber.Database;
using Saber.Database.Providers;

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
                new UserActivityProperties("you.", UserActivityType.Watching)
            }
        };
    })
    .AddSingleton<ApplicationCommandService<ApplicationCommandContext, AutocompleteInteractionContext>>()
    .AddSingleton<CommandService<CommandContext>>()
    .AddGatewayEventHandlers(typeof(Program).Assembly);

var googleConfig = new BaseClientService.Initializer
{
    ApiKey = config["GoogleApiKey"],
    ApplicationName = "SaberBot"
};

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59");

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
    .AddTransient<ItemService>()
    .AddSingleton(FirefoxDriverService.CreateDefaultService());

builder.Services.AddOpenAIService(s => { s.ApiKey = config["OpenAI:ApiKey"]; });

builder.Services
    .AddSingleton<OpenAiService>()
    .AddSingleton<IChatBot>(x => x.GetRequiredService<OpenAiService>())
    .AddSingleton<IImageGen>(x => x.GetRequiredService<OpenAiService>())
    .AddSingleton<ISummaryService, AiSummariseService>();

var host = builder.Build();

var client = host.Services.GetRequiredService<GatewayClient>();
var logger = host.Services.GetRequiredService<ILogger>();

client.Log += m => logger.LogAsync(m);

var applicationCommands = host.Services
    .GetRequiredService<ApplicationCommandService<ApplicationCommandContext, AutocompleteInteractionContext>>();
applicationCommands.AddModules(typeof(Program).Assembly);
await applicationCommands.CreateCommandsAsync(client.Rest, client.Id);

var commandService = host.Services.GetRequiredService<CommandService<CommandContext>>();
commandService.AddModules(typeof(Program).Assembly);

host.AddModules(typeof(Program).Assembly);
host.UseGatewayEventHandlers();

var oldTempFiles = config.TempDir
    .GetFiles("*", SearchOption.TopDirectoryOnly)
    .Where(x => x.LastAccessTime < DateTime.Now.AddDays(-14));

foreach (var file in oldTempFiles)
    file.Delete();

client.Ready += args =>
{
    Console.WriteLine(
        "__________        __    .__                                    .___      ._.\n\\______   \\ _____/  |_  |__| ______ _______   ____ _____     __| _/__.__.| |\n |    |  _//  _ \\   __\\ |  |/  ___/ \\_  __ \\_/ __ \\\\__  \\   / __ <   |  || |\n |    |   (  <_> )  |   |  |\\___ \\   |  | \\/\\  ___/ / __ \\_/ /_/ |\\___  | \\|\n |______  /\\____/|__|   |__/____  >  |__|    \\___  >____  /\\____ |/ ____| __\n        \\/                      \\/               \\/     \\/      \\/\\/      \\/");
    return ValueTask.CompletedTask;
};


await host.RunAsync();