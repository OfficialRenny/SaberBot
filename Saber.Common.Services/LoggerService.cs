﻿using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services
{
    public class LoggerService
    {
        public Task LogAsync(LogMessage message)
        {
            if (message.Exception is CommandException cmdException)
            {
                Console.WriteLine($"[Command/{message.Severity}] {cmdException.Command.Aliases.First()}"
                    + $" failed to execute in {cmdException.Context.Channel}.");
                Console.WriteLine(cmdException);
            }
            else
                Console.WriteLine($"[General/{message.Severity}] {message}");

            return Task.CompletedTask;
        }

        public Task Log(LogSeverity severity, string source, string message, Exception? ex = null) => Log(new LogMessage(severity, source, message, ex));
        public Task Log(LogMessage message) => LogAsync(message);
    }
}
