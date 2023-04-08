using Discord.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Discord;

namespace SaberBot.Commands.Interactions
{
    public class YoutubeInteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly YouTubeService _youTubeService;

        public YoutubeInteractionModule(YouTubeService service)
        {
            _youTubeService = service;
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
    }
}
