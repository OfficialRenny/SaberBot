using System.Net.Http.Headers;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.DependencyInjection;
using Saber.Common;
using Saber.Database;
using System.Web;
using RestSharp;
using System.Reflection;
using Discord.Interactions;
using Discord.Rest;
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

namespace Saber.Bot
{
    public class Bot
    {
        private readonly IServiceProvider _service;
        private readonly DiscordSocketClient _client;
        private readonly Config _config;

        public Bot() 
        {
            _service = CreateProvider();
            _client = _service.GetRequiredService<DiscordSocketClient>();
            _config = _service.GetRequiredService<Config>();
        }

        public static Task Main(string[] args) => new Bot().MainAsync();
        public async Task MainAsync()
        {
            var config = _service.GetRequiredService<Config>();
            var logger = _service.GetRequiredService<ILogger>();
            
            _client.Log += logger.LogAsync;
            
            await _client.LoginAsync(TokenType.Bot, _config["DiscordToken"]);
            await _client.StartAsync();

            var commandHandler = _service.GetRequiredService<CommandHandler>();
            await commandHandler.InstallCommandsAsync();

            var interactionHandler = _service.GetRequiredService<InteractionHandler>();
            await interactionHandler.SetupCommandsAsync();
            
            var oldTempFiles = config.TempDir
                .GetFiles("*", SearchOption.TopDirectoryOnly)
                .Where(x => x.LastAccessTime < DateTime.Now.AddDays(-14));
            
            foreach (var file in oldTempFiles)
                file.Delete();

            _client.Ready += Ready;

            await Task.Delay(-1);
        }

        private async Task Ready()
        {
            Console.WriteLine("__________        __    .__                                    .___      ._.\n\\______   \\ _____/  |_  |__| ______ _______   ____ _____     __| _/__.__.| |\n |    |  _//  _ \\   __\\ |  |/  ___/ \\_  __ \\_/ __ \\\\__  \\   / __ <   |  || |\n |    |   (  <_> )  |   |  |\\___ \\   |  | \\/\\  ___/ / __ \\_/ /_/ |\\___  | \\|\n |______  /\\____/|__|   |__/____  >  |__|    \\___  >____  /\\____ |/ ____| __\n        \\/                      \\/               \\/     \\/      \\/\\/      \\/");
        }

        static IServiceProvider CreateProvider()
        {
            var globalConfig = new Config();

            var clientConfig = new DiscordSocketConfig
            {
                LogGatewayIntentWarnings = true,
                GatewayIntents = GatewayIntents.All,
                LogLevel = LogSeverity.Info,
                AlwaysDownloadUsers = true,
                MessageCacheSize = 4096,
            };
            var commandConfig = new CommandServiceConfig
            {
                DefaultRunMode = Discord.Commands.RunMode.Async,
                LogLevel = LogSeverity.Info
            };

            var googleConfig = new BaseClientService.Initializer()
            {
                ApiKey = globalConfig["GoogleApiKey"],
                ApplicationName = "SaberBot"
            };

            var interactionConfig = new InteractionServiceConfig 
            {
                LogLevel = LogSeverity.Info,
                DefaultRunMode = Discord.Interactions.RunMode.Async,
            };

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59");

            var collection = new ServiceCollection()
                .AddSingleton(globalConfig)
                .AddSingleton<IConfiguration>(globalConfig)
                .AddDbContext<Db>(options => options.UseSqlServer(globalConfig["Database:ConnectionString"]), ServiceLifetime.Transient)
                .AddSingleton<ILogger, LoggerService>()
                .AddTransient<UserProfileProvider>()
                .AddTransient<GuildProvider>()
                .AddSingleton(httpClient)
                .AddSingleton(clientConfig)
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton(commandConfig)
                .AddSingleton<CommandService>()
                .AddSingleton(interactionConfig)
                .AddSingleton<InteractionService>()
                .AddSingleton<CommandHandler>()
                .AddSingleton<InteractionHandler>()
                .AddSingleton(googleConfig)
                .AddScoped<YouTubeService>()
                .AddSingleton<AudioService>()
                .AddSingleton<YoutubeDlService>()
                .AddSingleton<FileUploaderService>()
                //.AddSingleton<OneLinerService>()
                .AddSingleton<WarframeService>()
                .AddTransient<ItemService>();

            collection.AddSingleton<IRestClientProvider>(x => x.GetRequiredService<DiscordSocketClient>());
            
            collection.AddOpenAIService(settings => { settings.ApiKey = globalConfig["OpenAI:ApiKey"]; });
            collection.AddSingleton<OpenAiService>();

            collection
                .AddSingleton<IChatBot>(x => x.GetRequiredService<OpenAiService>())
                .AddSingleton<IImageGen>(x => x.GetRequiredService<OpenAiService>())
                .AddSingleton<ISummaryService, AiSummariseService>();

            return collection.BuildServiceProvider();
        }
    }
}