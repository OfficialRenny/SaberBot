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
using Saber.Bot.Core.Handlers;
using Saber.Common.Services;
using Saber.Database.Providers;
using YoutubeDLSharp.Options;
using Saber.Common.AppSettings;
using Microsoft.Extensions.Configuration;
using Saber.Bot.Core;
using Microsoft.EntityFrameworkCore;
using OpenAI.Extensions;

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

            var commands = _service.GetRequiredService<CommandService>();

            await _client.LoginAsync(TokenType.Bot, _config["DiscordToken"]);
            await _client.StartAsync();

            var commandHandler = _service.GetRequiredService<CommandHandler>();
            await commandHandler.InstallCommandsAsync();

            var interactionHandler = _service.GetRequiredService<InteractionHandler>();
            await interactionHandler.SetupCommandsAsync();

            var logger = _service.GetRequiredService<Logger>();

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
            Console.WriteLine("Bot is ready!");          
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
                MessageCacheSize = 1024,
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

            var collection = new ServiceCollection()
                .AddSingleton(globalConfig)
                .AddDbContext<Db>(options => options.UseSqlServer(globalConfig["Database:ConnectionString"]), ServiceLifetime.Transient)
                .AddSingleton<LoggerService>()
                .AddTransient<UserProfileProvider>()
                .AddTransient<GuildProvider>()
                .AddSingleton<HttpClient>()
                .AddSingleton(clientConfig)
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton(commandConfig)
                .AddSingleton<CommandService>()
                .AddSingleton(interactionConfig)
                .AddSingleton<InteractionService>()
                .AddSingleton<Logger>()
                .AddSingleton<CommandHandler>()
                .AddSingleton<InteractionHandler>()
                .AddSingleton(googleConfig)
                .AddScoped<YouTubeService>()
                .AddSingleton<AudioService>()
                .AddSingleton<YoutubeDlService>()
                .AddSingleton<FileUploaderService>()
                //.AddSingleton<OneLinerService>()
                .AddSingleton<WarframeService>()
                .AddSingleton<SmmryService>()
                .AddTransient<ItemService>();

            collection.AddOpenAIService(settings => { settings.ApiKey = globalConfig["OpenAI:ApiKey"]; });
            collection.AddSingleton<OpenAiService>();

            return collection.BuildServiceProvider();
        }
    }
}