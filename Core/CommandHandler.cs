using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SaberBot.Database;
using SaberBot.Database.Models;
using Discord.Interactions;

namespace SaberBot.Core
{
    public class CommandHandler
    {
        private readonly IServiceProvider _services;
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commands;
        private readonly DbProvider _dbProvider;

        public CommandHandler(IServiceProvider services, DiscordSocketClient client, CommandService commands, DbProvider dbProvider)
        {
            _services = services;
            _commands = commands;
            _client = client;
            _dbProvider = dbProvider;
        }

        public async Task InstallCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;

            var addedModules = await _commands.AddModulesAsync(assembly: Assembly.GetEntryAssembly(),
                                            services: _services);
        }

        private async Task HandleCommandAsync(SocketMessage messageParam)
        {
            // Don't process the command if it was a system message or sent by a bot
            var message = messageParam as SocketUserMessage;
            if (message == null || message.Author.IsBot) return;

            UserProfile user = _dbProvider.GetOrCreateUserProfile(message.Author.Id);
            user.LastKnownDisplayName = message.Author.Username;
            user.IncrementMessagesSent();
            _dbProvider.SaveChanges();

            string prefix =
                message.Channel is SocketGuildChannel
                ? _dbProvider.GetOrCreateCommandPrefix(((SocketGuildChannel)message.Channel).Guild.Id).Prefix
                : ";";

            int argPos = 0;
            if (message.HasStringPrefix(prefix, ref argPos) ||
                message.HasMentionPrefix(_client.CurrentUser, ref argPos))
            {
                var context = new SocketCommandContext(_client, message);
                var commandResult = await _commands.ExecuteAsync(
                    context: context,
                    argPos: argPos,
                    services: _services);

                if (commandResult.IsSuccess)
                {
                    user.IncrementCommandsExecuted();
                    _dbProvider.SaveChanges();
                }
            }
        }
    }
}
