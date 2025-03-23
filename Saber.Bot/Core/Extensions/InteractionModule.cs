using NetCord;
using NetCord.Gateway;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core.Extensions;

public partial class InteractionModule<T> : ApplicationCommandModule<T> where T : ApplicationCommandContext
{
    public required Config Config { get; set; }
    public required ILogger Logger { get; set; }
    
    protected async Task DeferAsync(bool ephemeral = false)
        => await RespondAsync(InteractionCallback.DeferredMessage(ephemeral ? MessageFlags.Ephemeral : null));
    
    protected async Task<RestMessage> FollowupAsyncTooLong(string response)
    {
        if (response.Length > 2000)
        {
            try
            {
                var tempFile = Path.Join(Config.TempDir.FullName, $"{Guid.NewGuid()}.txt");
                await File.WriteAllTextAsync(tempFile, response);

                return await FollowupAsync(message: new InteractionMessageProperties
                {
                    Attachments = new []
                    {
                        new AttachmentProperties("response.txt", File.OpenRead(tempFile))
                    },
                    Content = "The response would have been too long, so I have attached it as a text file instead."
                });
            } catch (Exception ex)
            {
                await Logger.LogAsync(LogSeverity.Error, nameof(FollowupAsyncTooLong), ex.Message, ex);
                return await FollowupAsync("Error: The response would have been too long, and I failed to attach it as a text file.");
            }
        }
        else
        {
            return await FollowupAsync(response);
        }
    }
    
    protected async Task<RestMessage> FollowupWithFilesAsync(IEnumerable<AttachmentProperties> files, string response = null)
    {
        return await FollowupAsync(message: new InteractionMessageProperties
        {
            Attachments = files.ToArray(),
            Content = response
        });
    }
    
    protected async Task RespondAsync(string response, bool ephemeral = false)
        => await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
        {
            Content = response,
            Flags = ephemeral ? MessageFlags.Ephemeral : null
        }));
    
    protected async Task<RestMessage> FollowupAsync(string response, bool ephemeral = false)
        => await FollowupAsync(message: new InteractionMessageProperties
        {
            Content = response,
            Flags = ephemeral ? MessageFlags.Ephemeral : null
        });
}