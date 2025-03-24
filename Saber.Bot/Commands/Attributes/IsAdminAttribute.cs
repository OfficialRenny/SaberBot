using Microsoft.Extensions.DependencyInjection;
using NetCord.Services;
using Saber.Database.Providers;

namespace Saber.Bot.Commands.Attributes;

public class IsAdminAttribute<TContext> : PreconditionAttribute<TContext> where TContext : IUserContext
{
    public override ValueTask<PreconditionResult> EnsureCanExecuteAsync(TContext context, IServiceProvider? services)
    {
        var provider = services.GetRequiredService<UserProfileProvider>();
        var user = provider.GetUserProfile(context.User.Id);

        return new ValueTask<PreconditionResult>(user is { IsAdmin: true }
            ? PreconditionResult.Success
            : PreconditionResult.Fail("You must be an admin to use this command."));
    }
}