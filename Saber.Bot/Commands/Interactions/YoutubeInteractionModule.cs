using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using YoutubeDLSharp;
using Saber.Common;
using Saber.Common.Services;
using Saber.Bot.Core;
using Saber.Database;
using Saber.Database.Providers;
using System.IO;
using System.Security.Policy;
using NetCord;
using NetCord.Gateway;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using NetCord.Rest;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Commands.Interactions
{
    public class YoutubeInteractionModule(
        ILogger logger,
        YouTubeService service,
        YoutubeDlService youtubeDlService,
        Db db,
        FileUploaderService fileUploaderService)
        : InteractionModule<ApplicationCommandContext>
    {
        private readonly CachedFileProvider _cachedFileProvider = new(db);

        [SlashCommand("yt", "YouTube search")]
        public async Task Search(string? searchTerm)
        {
            await DeferAsync();

            await DoSearch(searchTerm);
        }

        [SlashCommand("rp2yt", "Does a youtube search for whatever you/someone else is currently listening to.")]
        public async Task Rp2Yt(User? user = null)
        {
            await DeferAsync();

            user ??= Context.User;

            var userPresence = Context.Client.Cache.Guilds.SelectMany(x => x.Value.Presences).Where(x => x.Value.User.Id == user.Id).Select(x => x.Value).FirstOrDefault();
            if (userPresence == null)
            {
                await FollowupAsync($"Could not presence status for {user.Username}.");
                return;
            }
            
            var musicPresences = userPresence.Activities.Where(n => n.Type == UserActivityType.Listening).ToList();
            if (musicPresences.Count != 0)
            {
                var cur = musicPresences.First();
                string? songTitle = "";
                // if (cur is SpotifyGame s)
                //     songTitle = $"{string.Join(", ", s.Artists)} - {s.TrackTitle}";
                // else
                //     songTitle = cur.Details;
                songTitle = cur.Details;

                await DoSearch(songTitle);
            }
        }

        public Task DoSearch(string? search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return FollowupAsync("Task failed successfully. (Search was empty.)");

            SearchResource.ListRequest listRequest = service.Search.List("snippet");
            listRequest.MaxResults = 3;
            listRequest.Q = search;
            listRequest.Type = "video";

            SearchListResponse resp = listRequest.Execute();

            return FollowupAsync(resp.Items.Any() ? $"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}" : "Task failed successfully. (Couldn't find any search results for some reason...)");
        }

        [HasAccessFlag<ApplicationCommandContext>(Database.Models.Profile.AccessRoles.YoutubeDl)]
        [MessageCommand("YTDL - Audio")]
        public async Task DownloadAsAudio(RestMessage message)
        {
            await DownloadFile(message, DownloadType.Audio, false);
        }

        [HasAccessFlag<ApplicationCommandContext>(Database.Models.Profile.AccessRoles.YoutubeDl)]
        [MessageCommand("YTDL - Video")]
        public async Task DownloadAsVideo(RestMessage message)
        {
            await DownloadFile(message, DownloadType.Video, false);
        }

        [HasAccessFlag<ApplicationCommandContext>(Database.Models.Profile.AccessRoles.YoutubeDl)]
        [MessageCommand("YTDL - Video (Private)")]
        public async Task DownloadAsVideoEphemeral(RestMessage message)
        {
            await DownloadFile(message, DownloadType.Video, true);
        }

        [HasAccessFlag<ApplicationCommandContext>(Database.Models.Profile.AccessRoles.YoutubeDl)]
        [MessageCommand("YTDL - Audio (Private)")]
        public async Task DownloadAsAudioEphemeral(RestMessage message)
        {
            await DownloadFile(message, DownloadType.Audio, true);
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
            if (!(await validUrls.AnyAsync()))
            {
                await FollowupAsync("No valid URLs found in message.", ephemeral: ephemeral);
                return;
            }

            var url = (await validUrls.FirstAsync());

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
}
