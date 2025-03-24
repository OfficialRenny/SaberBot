using NetCord;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;
using Saber.Common.Extensions;
using Saber.Common.Services.Interfaces;
using Saber.Database.Providers;

namespace Saber.Bot.Core.Handlers;

[GatewayEvent(nameof(GatewayClient.InteractionCreate))]
public class InteractionHandler(
    IServiceProvider services,
    GatewayClient client,
    ApplicationCommandService<ApplicationCommandContext, AutocompleteInteractionContext> interactionService,
    UserProfileProvider userProfileProvider,
    ILogger logger)
    : IGatewayEventHandler<Interaction>
{
    public async ValueTask HandleAsync(Interaction interaction)
    {
        var interactionUser = interaction.User;
        if (interactionUser.IsBot || interactionUser.IsSystemUser == true)
            return;

        var result = await (interaction switch
        {
            ApplicationCommandInteraction applicationCommandInteraction => interactionService.ExecuteAsync(
                new ApplicationCommandContext(applicationCommandInteraction, client), services),
            AutocompleteInteraction autocompleteInteraction => interactionService.ExecuteAutocompleteAsync(
                new AutocompleteInteractionContext(autocompleteInteraction, client), services),
            _ => throw new Exception("Unsupported interaction type.")
        });

        if (result is not IFailResult failResult)
        {
            var user = userProfileProvider.GetOrCreateProfile(interactionUser.Id);

            user.LastKnownDisplayName = interaction.User.GetDisplayName();
            user.IncrementCommandsExecuted();
            userProfileProvider.Save();
        }
        else
        {
            await logger.LogAsync(LogSeverity.Error, nameof(HandleAsync), failResult.Message);
            await interaction.SendFollowupMessageAsync(failResult.Message);
        }
    }
}