using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Saber.Database;
using System.Reflection.Metadata;
using System.Diagnostics;
using NetCord;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core.Handlers;

[GatewayEvent(nameof(GatewayClient.InteractionCreate))]
public class InteractionHandler(
    IServiceProvider services,
    GatewayClient client,
    ApplicationCommandService<ApplicationCommandContext> interactionService,
    UserProfileProvider userProfileProvider,
    ILogger logger)
    : IGatewayEventHandler<Interaction>
{
    public async ValueTask HandleAsync(Interaction interaction)
    {
        if (interaction is not ApplicationCommandInteraction applicationCommandInteraction)
            return;
        
        var interactionUser = applicationCommandInteraction.User;
        if (interactionUser.IsBot || interactionUser.IsSystemUser == true)
            return;
        
        var user = userProfileProvider.GetOrCreateProfile(interactionUser.Id);
        
        user.LastKnownDisplayName = interaction.User.GlobalName ?? interaction.User.Username;
        userProfileProvider.Save();

        var context = new ApplicationCommandContext(applicationCommandInteraction, client);
        var interactionResult = await interactionService.ExecuteAsync(context, services);

        if (interactionResult is not IFailResult failResult)
        {
            user.IncrementCommandsExecuted();
            userProfileProvider.Save();
        }
        else
        {
            await logger.LogAsync(LogSeverity.Error, nameof(HandleAsync), failResult.Message);
        }
    }
}