using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using Saber.Database;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Attributes
{
    public class IsAdminAttribute : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            var provider = services.GetRequiredService<UserProfileProvider>();
            var user = provider.GetUserProfile(context.User.Id);

            return Task.FromResult(user is { IsAdmin: true } ? PreconditionResult.FromSuccess() : PreconditionResult.FromError("You must be an admin to use this command."));
        }
    }
}
