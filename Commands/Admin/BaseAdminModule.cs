using Discord;
using Discord.Commands;
using SaberBot.Core.Attributes;
using SaberBot.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Commands.Admin
{
    [RequireOwner(Group = "OwnerOrAdmin")]
    [IsAdmin(Group = "OwnerOrAdmin")]
    [Group("admin")]
    public class BaseAdminModule : ModuleBase<SocketCommandContext>
    {
        private readonly DbProvider _dbProvider;
        public BaseAdminModule(DbProvider dbProvider) 
        { 
            _dbProvider = dbProvider;
        }

        [Command("toggleadmin")]
        [Summary("Toggles admin status for a user.")]
        public Task ToggleAdmin(IUser user)
        {
            var uerProfile = _dbProvider.GetOrCreateUserProfile(user.Id);
            uerProfile.IsAdmin = !uerProfile.IsAdmin;
            _dbProvider.SaveChanges();
            return ReplyAsync($"User {user.Username} is now {(uerProfile.IsAdmin ? "an admin" : "not an admin")}.");
        }
    }
}
