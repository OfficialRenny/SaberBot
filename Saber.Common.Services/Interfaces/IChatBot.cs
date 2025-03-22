using Discord;

namespace Saber.Common.Services.Interfaces;

public interface IChatBot
{
    public Task<string> Ask(string question);
    public Task<string> Ask(string question, IUser? user, IGuild? guild);
    
    public bool ClearHistory(ulong serverId);
}