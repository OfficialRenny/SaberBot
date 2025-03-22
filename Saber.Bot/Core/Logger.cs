using Discord.Commands;
using Discord.WebSocket;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Interactions;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core
{
    public class BotLogger
    {
        public BotLogger(ILogger logger, DiscordSocketClient client, CommandService command, InteractionService interaction)
        {
            client.Log += logger.LogAsync;
            command.Log += logger.LogAsync;
            interaction.Log += logger.LogAsync;
        }
    }
}
