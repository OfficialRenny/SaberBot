using Discord.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Discord;
using YoutubeDLSharp;
using Saber.Common;
using Saber.Common.Services;
using Saber.Bot.Core;
using Saber.Database;
using Saber.Database.Providers;
using System.IO;
using System.Security.Policy;

namespace Saber.Bot.Commands.Interactions
{
    public class YoutubeInteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly YouTubeService _youTubeService;
        private readonly YoutubeDlService _youtubeDlService;
        private readonly FileUploaderService _fileUploaderService;
        private readonly CachedFileProvider _cachedFileProvider;

        public YoutubeInteractionModule(YouTubeService service, YoutubeDlService youtubeDlService, Db db, FileUploaderService fileUploaderService)
        {
            _youTubeService = service;
            _youtubeDlService = youtubeDlService;
            _cachedFileProvider = new CachedFileProvider(db);
            _fileUploaderService = fileUploaderService;
        }

        [SlashCommand("yt", "YouTube search")]
        public async Task Search(string searchTerm)
        {
            await DeferAsync();

            await DoSearch(searchTerm);
        }

        [SlashCommand("rp2yt", "Does a youtube search for whatever you/someone else is currently listening to.")]
        public async Task Rp2Yt(IUser? user = null)
        {
            await DeferAsync();

            user ??= Context.User;

            var musicPresences = user.Activities.Where(n => n.Type == ActivityType.Listening).ToList();

            if (musicPresences.Any())
            {
                var cur = musicPresences.First();
                string songTitle = "";
                if (cur is SpotifyGame)
                {
                    SpotifyGame s = (SpotifyGame)cur;
                    songTitle = $"{string.Join(", ", s.Artists)} - {s.TrackTitle}";
                }
                else
                {
                    songTitle = cur.Details;
                }

                await DoSearch(songTitle);
            }
        }

        public Task DoSearch(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return FollowupAsync("Task failed successfully. (Search was empty.)");

            SearchResource.ListRequest listRequest = _youTubeService.Search.List("snippet");
            listRequest.MaxResults = 3;
            listRequest.Q = search;
            listRequest.Type = "video";

            SearchListResponse resp = listRequest.Execute();

            if (resp.Items.Any())
                return FollowupAsync($"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}", ephemeral: false);
            else
                return FollowupAsync("Task failed successfully. (Couldn't find any search results for some reason...)");
        }

        [MessageCommand("YTDL - Audio")]
        public async Task DownloadAsAudio(IMessage message)
        {
            await DownloadFile(message, DownloadType.Audio, false);
        }

        [MessageCommand("YTDL - Video")]
        public async Task DownloadAsVideo(IMessage message)
        {
            await DownloadFile(message, DownloadType.Video, false);
        }

        [MessageCommand("YTDL - Video (Private)")]
        public async Task DownloadAsVideoEphemeral(IMessage message)
        {
            await DownloadFile(message, DownloadType.Video, true);
        }

        [MessageCommand("YTDL - Audio (Private)")]
        public async Task DownloadAsAudioEphemeral(IMessage message)
        {
            await DownloadFile(message, DownloadType.Audio, true);
        }

        public async Task DownloadFile(IMessage message, DownloadType type, bool ephemeral = true)
        {
            await DeferAsync(ephemeral);

            var messageHasUrls = Helpers.GetUrls(message.Content);
            if (!messageHasUrls.Any())
            {
                await FollowupAsync("No URLs found in message.", ephemeral: ephemeral);
                return;
            }

            var validUrls = _youtubeDlService.GetValidUrlsAsync(message.Content);
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
                await _youtubeDlService.Download(url, type), 
                type
            );

            return;
        }

        public async Task RespondWithFile(string url, FileInfo? file, DownloadType type = DownloadType.Video)
        {
            if (file?.Exists == true)
            {
                var uploaderResp = await _fileUploaderService.UploadFile(file.FullName);
                if (uploaderResp == null || string.IsNullOrEmpty(uploaderResp.Url))
                {
                    try
                    {
                        await FollowupWithFileAsync(
                            new FileAttachment(file.OpenRead(), file.Name)
                        );
                    }
                    catch (Exception ex) { }

                    return;
                }
                
                await FollowupAsync($"Here is a download link to the requested file:\n{uploaderResp.Url}");
                _cachedFileProvider.AddUrlToCache(url, uploaderResp.Url, file.Name, type, Context.User.Id);
                file.Delete();
            }
        }
    }
}
