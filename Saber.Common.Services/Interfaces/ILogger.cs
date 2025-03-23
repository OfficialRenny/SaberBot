using NetCord.Gateway;

namespace Saber.Common.Services.Interfaces;

public interface ILogger
{
    public ValueTask LogAsync(LogMessage message);
    public ValueTask LogAsync(LogSeverity severity, string source, string message, Exception? ex = null);
}