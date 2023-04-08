using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.DependencyInjection;
using SaberBot.Core;
using SaberBot.Database;
using System.Web;
using RestSharp;
using System.Reflection;
using Discord.Interactions;
using SaberBot.Core.Handlers;
using SaberBot.Core.Services;
using SaberBot.Database.Providers;

namespace SaberBot
{
    public class Bot
    {
        private readonly IServiceProvider _service;
        private readonly DiscordSocketClient _client;

        public Bot() 
        {
            _service = CreateProvider();
            _client = _service.GetRequiredService<DiscordSocketClient>();
        }

        public static Task Main(string[] args) => new Bot().MainAsync();
        public async Task MainAsync()
        {
            var commands = _service.GetRequiredService<CommandService>();

            await _client.LoginAsync(TokenType.Bot, Config.DiscordToken);
            await _client.StartAsync();

            var commandHandler = _service.GetRequiredService<CommandHandler>();
            await commandHandler.InstallCommandsAsync();

            var interactionHandler = _service.GetRequiredService<InteractionHandler>();
            await interactionHandler.SetupCommandsAsync();

            var logger = _service.GetRequiredService<Logger>();

            _client.Ready += Ready;

            await Task.Delay(-1);
        }

        private async Task Ready()
        {
            Console.WriteLine("Bot is ready!");          
        }

        static IServiceProvider CreateProvider()
        {
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
                ApiKey = Config.GoogleApiKey,
                ApplicationName = "SaberBot"
            };

            var interactionConfig = new InteractionServiceConfig 
            {
                LogLevel = LogSeverity.Info,
                DefaultRunMode = Discord.Interactions.RunMode.Async,
            };

            var collection = new ServiceCollection()
                .AddDbContext<Db>(ServiceLifetime.Transient)
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
                .AddTransient<ItemService>();

            return collection.BuildServiceProvider();
        }
    }
}