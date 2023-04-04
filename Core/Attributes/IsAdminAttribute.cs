using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using SaberBot.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Core.Attributes
{
    public class IsAdminAttribute : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            var provider = services.GetRequiredService<DbProvider>();
            var user = provider.GetOrCreateUserProfile(context.User.Id);

            if (user.IsAdmin)
                return Task.FromResult(PreconditionResult.FromSuccess());
            else
                return Task.FromResult(PreconditionResult.FromError("You must be an admin to use this command."));
        }
    }
}
