using NetCord;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Extensions;
using Saber.Common.Services.Interfaces;
using Saber.Database;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;

namespace Saber.Bot.Commands.Interactions.Admin;

[IsAdmin<ApplicationCommandContext>]
[SlashCommand("admin", "Admin commands")]
public class BaseAdminModule(
    Config config,
    ILogger logger,
    Db db)
    : InteractionModule<ApplicationCommandContext>(config, logger)
{
    private readonly UserProfileProvider _provider = new(db);

    [SubSlashCommand("cleanup", "Clean up the last X messages created by the bot.")]
    public async Task CleanUp(int messageCount = 15)
    {
        await DeferAsync(true);

        var channelMessages = Context.Channel.GetMessagesAsync();
        var messages = channelMessages.Where(m => m.Author.Id == Context.Client.Id).OrderByDescending(m => m.CreatedAt)
            .Take(messageCount);

        var deleteTasks = new List<Task>();

        await foreach (var message in messages)
            deleteTasks.Add(Context.Channel.DeleteMessageAsync(message.Id));

        await Task.WhenAll(deleteTasks);

        await FollowupAsync($"Done, cleaned {deleteTasks.Count(t => t.IsCompleted)} messages.");
    }

    [SubSlashCommand("toggleadmin", "Toggles admin status for a user.")]
    public async Task ToggleAdmin(User user)
    {
        var d = DeferAsync(true);

        var userProfile = _provider.GetOrCreateProfile(user.Id);
        _provider.ModifyUserProfile(userProfile, u => u.IsAdmin = !u.IsAdmin);

        await d;
        await FollowupAsync(
            $"User {user.GetDisplayName()} is now {(userProfile.IsAdmin ? "an admin" : "not an admin")}.");
    }

    [SubSlashCommand("toggleaccessrole", "Toggles access to a specific role for a user.")]
    public async Task ToggleAccessRole(User user, AccessRoles roles)
    {
        var d = DeferAsync(true);

        var userProfile = _provider.GetOrCreateProfile(user.Id);
        _provider.ModifyUserProfile(userProfile, u => u.AccessRoles ^= roles);

        await d;
        await FollowupAsync(
            $"User {user.GetDisplayName()} now {(userProfile.AccessRoles.HasFlag(roles) ? "has" : "does not have")} access to {roles}.");
    }

    [SubSlashCommand("listaccessroles", "Lists all access roles for a user.")]
    public async Task ListAccessRoles(User user)
    {
        var d = DeferAsync(true);

        var userProfile = _provider.GetOrCreateProfile(user.Id);

        await d;
        await FollowupAsync($"User {user.GetDisplayName()} has access to {userProfile.AccessRoles}.");
    }
}