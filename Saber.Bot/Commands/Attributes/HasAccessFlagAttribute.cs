using Microsoft.Extensions.DependencyInjection;
using NetCord.Services;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;

namespace Saber.Bot.Commands.Attributes;

public class HasAccessFlagAttribute<TContext>(AccessRoles accessFlag)
    : PreconditionAttribute<TContext> where TContext : IUserContext
{
    public override ValueTask<PreconditionResult> EnsureCanExecuteAsync(TContext context,
        IServiceProvider? serviceProvider)
    {
        var provider = (serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider)))
            .GetRequiredService<UserProfileProvider>();
        var user = provider.GetUserProfile(context.User.Id);

        if (user == null)
            return new ValueTask<PreconditionResult>(PreconditionResult.Fail("Unable to find user profile."));

        if (user.IsAdmin || user.AccessRoles.HasFlag(accessFlag))
            return new ValueTask<PreconditionResult>(PreconditionResult.Success);
        return new ValueTask<PreconditionResult>(
            PreconditionResult.Fail("You do not have permission to use this command."));
    }
}