using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Saber.Database;
using Discord.Interactions;
using System.Reflection.Metadata;
using Discord;
using System.Diagnostics;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;
using Saber.Common;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core.Handlers
{
    public class InteractionHandler
    {
        private readonly Config _config;
        private readonly IServiceProvider _services;
        private readonly ILogger _logger;
        private readonly DiscordSocketClient _client;
        private readonly InteractionService _interactionService;
        private readonly UserProfileProvider _userProfileProvider;

        public InteractionHandler(Config config, IServiceProvider services, DiscordSocketClient client, InteractionService interactionService, UserProfileProvider userProfileProvider, ILogger logger)
        {
            _config = config;
            _services = services;
            _interactionService = interactionService;
            _client = client;
            
            _userProfileProvider = userProfileProvider;
            _logger = logger;
        }
        
        private async Task ReadyAsync()
        {
            var testGuild = _client.Guilds.FirstOrDefault(g => g.Id == Convert.ToUInt64(_config["TestGuildId"]));
            if (testGuild != null)
                await testGuild.DeleteApplicationCommandsAsync();
            
            if (Debugger.IsAttached)
            {
                await _interactionService.RegisterCommandsToGuildAsync(Convert.ToUInt64(_config["TestGuildId"]), true);
            }
            else
            {
                await _interactionService.RegisterCommandsGloballyAsync(true);
            }
        }

        public async Task SetupCommandsAsync()
        {
            _interactionService.Log += _logger.LogAsync;
            _client.Ready += ReadyAsync;

            var addedModules =
                await _interactionService.AddModulesAsync(
                    assembly: Assembly.GetEntryAssembly(),
                    services: _services);

            _client.InteractionCreated += HandleInteractionAsync;
        }

        private async Task HandleInteractionAsync(SocketInteraction interaction)
        {
            var user = _userProfileProvider.GetOrCreateProfile(interaction.User.Id);
            user.LastKnownDisplayName = interaction.User.GlobalName;
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
