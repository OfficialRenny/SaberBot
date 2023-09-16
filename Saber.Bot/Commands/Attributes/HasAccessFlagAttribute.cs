using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using Saber.Database;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Attributes
{
    public class HasAccessFlagAttribute : PreconditionAttribute
    {
        private readonly AccessRoles _accessFlag;

        public HasAccessFlagAttribute(AccessRoles accessFlag)
        {
            _accessFlag = accessFlag;
        }

        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            var provider = services.GetRequiredService<UserProfileProvider>();
            var user = provider.GetUserProfile(context.User.Id);

            if (user == null)
                return Task.FromResult(PreconditionResult.FromError("Unable to find user profile."));

            if (user.IsAdmin || user.AccessRoles.HasFlag(_accessFlag))
                return Task.FromResult(PreconditionResult.FromSuccess());
            else
                return Task.FromResult(PreconditionResult.FromError("You do not have permission to use this command."));
        }
    }
}
