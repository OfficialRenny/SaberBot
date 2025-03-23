using NetCord;
using NetCord.Gateway;

namespace Saber.Common.Services.Interfaces;

public interface IChatBot
{
    public Task<string> Ask(string question);
    public Task<string> Ask(string question, User? user, Guild? guild);
    
    public bool ClearHistory(ulong serverId);
}