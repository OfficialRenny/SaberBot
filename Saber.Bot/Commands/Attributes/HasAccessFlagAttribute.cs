using Microsoft.Extensions.DependencyInjection;
using Saber.Database;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCord;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;

namespace Saber.Bot.Commands.Attributes
{
    public class HasAccessFlagAttribute<TContext>(AccessRoles accessFlag)
        : PreconditionAttribute<TContext> where TContext : IUserContext
    {
        public override ValueTask<PreconditionResult> EnsureCanExecuteAsync(TContext context, IServiceProvider? serviceProvider)
        {
            var provider = (serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider))).GetRequiredService<UserProfileProvider>();
            var user = provider.GetUserProfile(context.User.Id);

            if (user == null)
                return new ValueTask<PreconditionResult>(PreconditionResult.Fail("Unable to find user profile."));

            if (user.IsAdmin || user.AccessRoles.HasFlag(accessFlag))
                return new ValueTask<PreconditionResult>(PreconditionResult.Success);
            else
                return new ValueTask<PreconditionResult>(PreconditionResult.Fail("You do not have permission to use this command."));
        }
    }
}
