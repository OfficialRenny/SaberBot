using Discord;

namespace Saber.Common.Services.Interfaces;

public interface ILogger
{
    public Task LogAsync(LogMessage message);
    public Task LogAsync(LogSeverity severity, string source, string message, Exception? ex = null);
}