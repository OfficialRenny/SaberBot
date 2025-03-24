using NetCord;
using NetCord.Gateway;
using Saber.Common.Extensions;

namespace Saber.Bot.Core.Extensions;

public static class MessageExtensions
{
    public static bool HasStringPrefix(this Message message, string prefix, ref int argPos)
    {
        if (!message.Content.StartsWith(prefix))
            return false;

        argPos = prefix.Length;
        return true;
    }

    public static bool HasMentionPrefix(this Message message, User user, ref int argPos)
    {
        if (!message.Content.StartsWith(user.GetMention()))
            return false;

        argPos = user.GetMention().Length;
        return true;
    }
}