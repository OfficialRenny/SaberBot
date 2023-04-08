using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SaberBot.Database;
using Discord.Interactions;
using SaberBot.Database.Models.Profile;
using SaberBot.Database.Providers;
using Discord;

namespace SaberBot.Core.Handlers
{
    public class CommandHandler
    {
        private readonly IServiceProvider _services;
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commands;
        private readonly GuildProvider _guildProvider;
        private readonly UserProfileProvider _userProfileProvider;

        public CommandHandler(IServiceProvider services, DiscordSocketClient client, CommandService commands, UserProfileProvider userProfileProvider, GuildProvider guildProvider)
        {
            _services = services;
            _commands = commands;
            _client = client;

            _userProfileProvider = userProfileProvider;
            _guildProvider = guildProvider;
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

            UserProfile user = _userProfileProvider.GetUserProfile(message.Author.Id);
            if (user == null)
                user = _userProfileProvider.CreateProfile(message.Author.Id, message.Author.Username);
            user.LastKnownDisplayName = message.Author.Username;
            user.IncrementMessagesSent();
            _userProfileProvider.Save();

            string prefix = ";";

            if (message.Channel is SocketGuildChannel)
            {
                IGuild guild = ((SocketGuildChannel)message.Channel).Guild;
                var dbGuild = _guildProvider.GetGuild(guild.Id);
                if (dbGuild == null)
                    dbGuild = _guildProvider.CreateGuild(guild);

                prefix = dbGuild.Prefix;
            }

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
                    _userProfileProvider.Save();
                }
            }
        }
    }
}
