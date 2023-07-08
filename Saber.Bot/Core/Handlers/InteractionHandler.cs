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
using System.Reflection.Metadata;
using Discord;
using System.Diagnostics;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;

namespace Saber.Bot.Core.Handlers
{
    public class InteractionHandler
    {
        private readonly IServiceProvider _services;
        private readonly DiscordSocketClient _client;
        private readonly InteractionService _interactionService;
        private readonly UserProfileProvider _userProfileProvider;

        public InteractionHandler(IServiceProvider services, DiscordSocketClient client, InteractionService interactionService, UserProfileProvider userProfileProvider)
        {
            _services = services;
            _interactionService = interactionService;
            _client = client;
            
            _userProfileProvider = userProfileProvider;
        }

        private async Task LogAsync(LogMessage log)
            => Console.WriteLine(log);

        private async Task ReadyAsync()
        {
            if (Debugger.IsAttached)
            {
                await _interactionService.RegisterCommandsToGuildAsync(Config.TestGuildId, true);
            }
            else
            {
                var testGuild = _client.Guilds.FirstOrDefault(g => g.Id == Config.TestGuildId);
                if (testGuild != null)
                    await testGuild.DeleteApplicationCommandsAsync();

                await _interactionService.RegisterCommandsGloballyAsync(true);
            }
        }

        public async Task SetupCommandsAsync()
        {
            _client.Ready += ReadyAsync;
            _interactionService.Log += LogAsync;

            var addedModules =
                await _interactionService.AddModulesAsync(
                    assembly: Assembly.GetEntryAssembly(),
                    services: _services);

            _client.InteractionCreated += HandleInteractionAsync;
        }

        private async Task HandleInteractionAsync(SocketInteraction interaction)
        {
            UserProfile user = _userProfileProvider.GetUserProfile(interaction.User.Id);
            user.LastKnownDisplayName = interaction.User.Username;
            _userProfileProvider.Save();

            var context = new SocketInteractionContext(_client, interaction);
            var interactionResult = await _interactionService.ExecuteCommandAsync(
                context,
                _services
            );

            if (interactionResult.IsSuccess)
            {
                user.IncrementCommandsExecuted();
                _userProfileProvider.Save();
            }
        }
    }
}
