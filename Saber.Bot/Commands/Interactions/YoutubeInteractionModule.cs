using Google.Apis.YouTube.v3;
using NetCord;
using NetCord.Gateway;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Extensions;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;
using Saber.Database;
using Saber.Database.Models.Profile;
using Saber.Database.Providers;

namespace Saber.Bot.Commands.Interactions;

public class YoutubeInteractionModule(
    Config config,
    ILogger logger,
    YouTubeService service,
    YoutubeDlService youtubeDlService,
    Db db,
    FileUploaderService fileUploaderService)
    : InteractionModule<ApplicationCommandContext>(config, logger)
{
    private readonly CachedFileProvider _cachedFileProvider = new(db);

    [SlashCommand("yt", "YouTube search")]
    public async Task Search(string? searchTerm)
    {
        await DeferAsync();

        await DoSearch(searchTerm);
    }
    
    public async Task DoSearch(string? search)
    {
        if (string.IsNullOrWhiteSpace(search))
        {
            await FollowupAsync("Task failed successfully. (Search was empty.)");
            return;
        }

        var resp = await service.GetSearch(search);

        await FollowupAsync(resp ?? "Task failed successfully. (Couldn't find any search results for some reason...)");
    }

    [HasAccessFlag<ApplicationCommandContext>(AccessRoles.YoutubeDl)]
    [MessageCommand("YTDL - Audio")]
    public async Task DownloadAsAudio(RestMessage message)
    {
        await DownloadFile(message, DownloadType.Audio, false);
    }

    [HasAccessFlag<ApplicationCommandContext>(AccessRoles.YoutubeDl)]
    [MessageCommand("YTDL - Video")]
    public async Task DownloadAsVideo(RestMessage message)
    {
        await DownloadFile(message, DownloadType.Video, false);
    }

    [HasAccessFlag<ApplicationCommandContext>(AccessRoles.YoutubeDl)]
    [MessageCommand("YTDL - Video (Private)")]
    public async Task DownloadAsVideoEphemeral(RestMessage message)
    {
        await DownloadFile(message, DownloadType.Video);
    }

    [HasAccessFlag<ApplicationCommandContext>(AccessRoles.YoutubeDl)]
    [MessageCommand("YTDL - Audio (Private)")]
    public async Task DownloadAsAudioEphemeral(RestMessage message)
    {
        await DownloadFile(message, DownloadType.Audio);
    }

    public async Task DownloadFile(RestMessage message, DownloadType type, bool ephemeral = true)
    {
        await DeferAsync(ephemeral);

        var messageHasUrls = Helpers.GetUrls(message.Content);
        if (!messageHasUrls.Any())
        {
            await FollowupAsync("No URLs found in message.", ephemeral);
            return;
        }

        var validUrls = youtubeDlService.GetValidUrlsAsync(message.Content);
        if (!await validUrls.AnyAsync())
        {
            await FollowupAsync("No valid URLs found in message.", ephemeral);
            return;
        }

        var url = await validUrls.FirstAsync();

        var cachedFile = _cachedFileProvider.GetCachedFile(url, type);
        if (cachedFile != null)
        {
            await FollowupAsync($"Here is a download link to the requested file:\n{cachedFile.UploadedUrl}");
            return;
        }

        await RespondWithFile(
            url,
            await youtubeDlService.Download(url, type),
            type
        );
    }

    public async Task RespondWithFile(string url, FileInfo? file, DownloadType type = DownloadType.Video)
    {
        if (file?.Exists == true)
        {
            var uploaderResp = await fileUploaderService.UploadFile(file.FullName);
            if (uploaderResp == null || string.IsNullOrEmpty(uploaderResp.Url))
            {
                try
                {
                    await FollowupWithFilesAsync(
                        [new AttachmentProperties(file.Name, file.OpenRead())]
                    );
                }
                catch (Exception ex)
                {
                    await logger.LogAsync(LogSeverity.Error, nameof(RespondWithFile), ex.Message, ex);
                }

                return;
            }

            await FollowupAsync($"Here is a download link to the requested file:\n{uploaderResp.Url}");
            _cachedFileProvider.AddUrlToCache(url, uploaderResp.Url, file.Name, type, Context.User.Id);
            file.Delete();
        }
    }
}