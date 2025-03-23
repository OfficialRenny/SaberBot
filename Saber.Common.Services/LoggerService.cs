using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCord.Gateway;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services
{
    public class LoggerService : ILogger
    {
        public async ValueTask LogAsync(LogMessage message)
        {
            // if (message.Exception is NetCord cmdException)
            // {
            //     Console.WriteLine($"[Command/{message.Severity}] {cmdException.Command.Aliases.First()}"
            //         + $" failed to execute in {cmdException.Context.Channel}.");
            //     Console.WriteLine(cmdException);
            // }
            // else
                Console.WriteLine($"[General/{message.Severity}] {message}");
        }

        public async ValueTask LogAsync(LogSeverity severity, string source, string message, Exception? ex = null)
        {
            Console.WriteLine($"[{source}/{severity}] {message}");
            if (ex != null)
                Console.WriteLine(ex);
        }
    }
}
