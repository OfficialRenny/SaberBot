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

            var userProfile = _provider.GetUserProfile(user.Id);

            userProfile.IsAdmin = !userProfile.IsAdmin;
            _provider.DbCtx.SaveChanges();

            await d;
            await FollowupAsync($"User {user.Username} is now {(userProfile.IsAdmin ? "an admin" : "not an admin")}.");
        }
    }
}
