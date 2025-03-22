using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services
{
    public class LoggerService : ILogger
    {
        public async Task LogAsync(LogMessage message)
        {
            if (message.Exception is CommandException cmdException)
            {
                Console.WriteLine($"[Command/{message.Severity}] {cmdException.Command.Aliases.First()}"
                    + $" failed to execute in {cmdException.Context.Channel}.");
                Console.WriteLine(cmdException);
            }
            else
                Console.WriteLine($"[General/{message.Severity}] {message}");
        }

        public async Task LogAsync(LogSeverity severity, string source, string message, Exception? ex = null) => LogAsync(new LogMessage(severity, source, message, ex));
    }
}
