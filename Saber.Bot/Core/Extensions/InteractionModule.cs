using Discord;
using Discord.Interactions;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core.Extensions;

public partial class InteractionModule<T> : InteractionModuleBase<T> where T : class, IInteractionContext
{
    public required Config Config { get; set; }
    public required ILogger Logger { get; set; }

    protected async Task<IUserMessage> FollowupAsyncTooLong(string response)
    {
        if (response.Length > 2000)
        {
            try
            {
                var tempFile = Path.Join(Config.TempDir.FullName, $"{Guid.NewGuid()}.txt");
                await File.WriteAllTextAsync(tempFile, response);

                return await FollowupWithFileAsync(tempFile,
                    fileName: "response.txt",
                    text: "The response would have been too long, so I have attached it as a text file instead.");
            } catch (Exception ex)
            {
                Logger.LogAsync(LogSeverity.Error, nameof(FollowupAsyncTooLong), ex.Message, ex);
                return await FollowupAsync("Error: The response would have been too long, and I failed to attach it as a text file.");
            }
        }
        else
        {
            return await FollowupAsync(response);   
        }
    }
}