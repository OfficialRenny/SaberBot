using Saber.Bot.Commands.Attributes;
using Saber.Database;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCord;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Core.Extensions;

namespace Saber.Bot.Commands.Interactions.Admin
{
    [IsAdmin<ApplicationCommandContext>]
    [SlashCommand("admin", "Admin commands")]
    public class BaseAdminModule(Db db) : InteractionModule<ApplicationCommandContext>
    {
        private readonly UserProfileProvider _provider = new(db);

        [SubSlashCommand("cleanup", "Clean up the last X messages created by the bot.")]
        public async Task CleanUp(int messageCount = 15)
        {
            await DeferAsync(true);
            
            var channelMessages = Context.Channel.GetMessagesAsync();
            var messages = channelMessages.Where(m => m.Author.Id == Context.Client.Id).OrderByDescending(m => m.CreatedAt).Take(messageCount);
            
            List<Task> deleteTasks = new List<Task>();

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
            await FollowupAsync($"User {user.Username} is now {(userProfile.IsAdmin ? "an admin" : "not an admin")}.");
        }

        [SubSlashCommand("toggleaccessrole", "Toggles access to a specific role for a user.")]
        public async Task ToggleAccessRole(User user, Database.Models.Profile.AccessRoles roles)
        {
            var d = DeferAsync(true);

            var userProfile = _provider.GetOrCreateProfile(user.Id);
            _provider.ModifyUserProfile(userProfile, u => u.AccessRoles ^= roles);

            await d;
            await FollowupAsync($"User {user.Username} now {(userProfile.AccessRoles.HasFlag(roles) ? "has" : "does not have")} access to {roles}.");
        }

        [SlashCommand("listaccessroles", "Lists all access roles for a user.")]
        public async Task ListAccessRoles(User user)
        {
            var d = DeferAsync(true);

            var userProfile = _provider.GetOrCreateProfile(user.Id);

            await d;
            await FollowupAsync($"User {user.Username} has access to {userProfile.AccessRoles}.");
        }
    }
}
