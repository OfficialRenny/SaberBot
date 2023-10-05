using Discord;
using Discord.Interactions;
using Saber.Bot.Commands.Attributes;
using Saber.Database;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Interactions.Admin
{
    [RequireOwner(Group = "OwnerOrAdmin")]
    [IsAdmin(Group = "OwnerOrAdmin")]
    [Group("admin", "Admin commands")]
    public class BaseAdminModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly UserProfileProvider _provider;

        public BaseAdminModule(Db db)
        {
            _provider = new UserProfileProvider(db);
        }

        [SlashCommand("cleanup", "Clean up the last X messages created by the bot.")]
        public async Task CleanUp(int messageCount = 15)
        {
            await DeferAsync(true);
            var messages = Context.Channel.CachedMessages.Where(m => m.Author.Id == Context.Client.CurrentUser.Id).OrderByDescending(m => m.Timestamp).Take(messageCount);

            List<Task> deleteTasks = new List<Task>();

            foreach (var message in messages)
                deleteTasks.Add(Context.Channel.DeleteMessageAsync(message));

            await Task.WhenAll(deleteTasks);

            await FollowupAsync($"Done, cleaned {deleteTasks.Count(t => t.IsCompleted)} messages.");
        }

        [SlashCommand("toggleadmin", "Toggles admin status for a user.")]
        public async Task ToggleAdmin(IUser user)
        {
            var d = DeferAsync(true);

            var userProfile = _provider.GetOrCreateProfile(user.Id);
            _provider.ModifyUserProfile(userProfile, u => u.IsAdmin = !u.IsAdmin);

            await d;
            await FollowupAsync($"User {user.Username} is now {(userProfile.IsAdmin ? "an admin" : "not an admin")}.");
        }

        [SlashCommand("toggleaccessrole", "Toggles access to a specific role for a user.")]
        public async Task ToggleAccessRole(IUser user, Database.Models.Profile.AccessRoles roles)
        {
            var d = DeferAsync(true);

            var userProfile = _provider.GetOrCreateProfile(user.Id);
            _provider.ModifyUserProfile(userProfile, u => u.AccessRoles ^= roles);

            await d;
            await FollowupAsync($"User {user.Username} now {(userProfile.AccessRoles.HasFlag(roles) ? "has" : "does not have")} access to {roles}.");
        }

        [SlashCommand("listaccessroles", "Lists all access roles for a user.")]
        public async Task ListAccessRoles(IUser user)
        {
            var d = DeferAsync(true);

            var userProfile = _provider.GetOrCreateProfile(user.Id);

            await d;
            await FollowupAsync($"User {user.Username} has access to {userProfile.AccessRoles}.");
        }
    }
}
