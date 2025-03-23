using NetCord;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Services;
using NetCord.Services.Commands;
using Saber.Bot.Core.Extensions;
using Saber.Common.Services.Interfaces;
using Saber.Database;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;

namespace Saber.Bot.Core.Handlers;

[GatewayEvent(nameof(GatewayClient.MessageCreate))]
public class MessageHandler(ILogger logger, IServiceProvider services, GuildProvider guildProvider, Db db, CommandService<CommandContext> commands, GatewayClient client) : IGatewayEventHandler<Message>
{
    private readonly UserProfileProvider _userProfileProvider = new UserProfileProvider(db);
    
    public async ValueTask HandleAsync(Message message)
    {
        // Don't process the command if it was a system message or sent by a bot
        if (message.Author.IsBot || message.Author.IsSystemUser == true) 
            return;

        UserProfile user = _userProfileProvider.GetOrCreateProfile(message.Author.Id);
        user.LastKnownDisplayName = message.Author.GlobalName ?? message.Author.Username;
        user.IncrementMessagesSent();
        _userProfileProvider.Save();

        string prefix = ";";
        if (message.Channel is TextGuildChannel)
        {
            if (message.Guild != null)
            {
                Guild guild = message.Guild;
                var dbGuild = guildProvider.GetGuild(guild.Id);
                dbGuild ??= guildProvider.CreateGuild(guild);

                prefix = dbGuild.Prefix;
            }
        }

        int argPos = 0;
        if (message.HasStringPrefix(prefix, ref argPos) ||
            message.HasMentionPrefix((await client.Rest.GetCurrentUserAsync()), ref argPos))
        {
            
            var context = new CommandContext(message, client);
            var result = await commands.ExecuteAsync(
                context: context,
                prefixLength: argPos,
                serviceProvider: services);

            if (result is not IFailResult failResult)
            {
                user.IncrementCommandsExecuted();
                _userProfileProvider.Save();
            }
            else
            {
                await logger.LogAsync(LogSeverity.Error, nameof(HandleAsync), failResult.Message);
            }
        }
    }
}