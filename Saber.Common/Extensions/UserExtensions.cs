using NetCord;

namespace Saber.Common.Extensions;

public static class UserExtensions
{
    public static string GetDisplayName(this User user)
    {
        return user.GlobalName ?? user.Username;
    }

    public static string GetMention(this User user)
    {
        return $"<@{user.Id}>";
    }
}