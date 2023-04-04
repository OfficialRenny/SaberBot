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

namespace SaberBot
{
    public class Bot
    {
        private readonly IServiceProvider _service;

        public Bot() 
        {
            _service = CreateProvider();
        }

        public static Task Main(string[] args) => new Bot().MainAsync();
        public async Task MainAsync()
        {
            var client = _service.GetRequiredService<DiscordSocketClient>();
            var commands = _service.GetRequiredService<CommandService>();

            await client.LoginAsync(TokenType.Bot, Config.DiscordToken);
            await client.StartAsync();

            var commandHandler = _service.GetRequiredService<CommandHandler>();
            await commandHandler.InstallCommandsAsync();

            var logger = _service.GetRequiredService<Logger>();

            client.Ready += Ready;

            await Task.Delay(-1);
        }

        private async Task Ready()
        {
            await Task.Run(() => { Console.WriteLine("Bot is ready!"); });
        }

        static IServiceProvider CreateProvider()
        {
            var clientConfig = new DiscordSocketConfig
            {
                LogGatewayIntentWarnings = true,
                GatewayIntents = GatewayIntents.All,
                LogLevel = LogSeverity.Info
            };
            var commandConfig = new CommandServiceConfig
            {
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Info
            };

            var googleConfig = new BaseClientService.Initializer()
            {
                ApiKey = Config.GoogleApiKey,
                ApplicationName = "SaberBot"
            };

            var collection = new ServiceCollection()
                .AddDbContext<Db>(ServiceLifetime.Transient)
                .AddTransient<DbProvider>()
                .AddSingleton<HttpClient>()
                .AddSingleton(clientConfig)
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton(commandConfig)
                .AddSingleton<CommandService>()
                .AddSingleton<Logger>()
                .AddSingleton<CommandHandler>()
                .AddSingleton(googleConfig)
                .AddScoped<YouTubeService>()
                .AddSingleton<AudioService>();

            return collection.BuildServiceProvider();
        }
    }
}