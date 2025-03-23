using Microsoft.Extensions.DependencyInjection;
using Saber.Database;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCord.Services;
using NetCord.Services.Commands;

namespace Saber.Bot.Commands.Attributes
{
    public class IsAdminAttribute<TContext> : PreconditionAttribute<TContext> where TContext : IUserContext
    {
        public override ValueTask<PreconditionResult> EnsureCanExecuteAsync(TContext context, IServiceProvider? services)
        {
            var provider = services.GetRequiredService<UserProfileProvider>();
            var user = provider.GetUserProfile(context.User.Id);

            return new ValueTask<PreconditionResult>(user is { IsAdmin: true } ? PreconditionResult.Success : PreconditionResult.Fail("You must be an admin to use this command."));
        }
    }
}
