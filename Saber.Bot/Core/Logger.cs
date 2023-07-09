using Discord.Commands;
using Discord.WebSocket;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services;

namespace Saber.Bot.Core
{
    public class Logger
    {
        public Logger(LoggerService loggerService, DiscordSocketClient client, CommandService command)
        {
            client.Log += loggerService.LogAsync;
            command.Log += loggerService.LogAsync;
        }
    }
}
