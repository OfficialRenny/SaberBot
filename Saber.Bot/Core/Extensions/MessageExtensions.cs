using NetCord;
using NetCord.Gateway;
using NetCord.JsonModels;
using NetCord.Rest;

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
        if (!message.Content.StartsWith(user.Mention())) 
            return false;
        
        argPos = user.Mention().Length;
        return true;
    }
}