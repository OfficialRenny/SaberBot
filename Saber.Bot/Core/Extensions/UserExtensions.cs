using NetCord;

namespace Saber.Bot.Core.Extensions;

public static class UserExtensions
{
    public static string Mention(this User user) => $"<@{user.Id}>";
}