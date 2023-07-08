using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Discord;

namespace Saber.Bot.Commands.Text
{
    public class YoutubeModule : ModuleBase<SocketCommandContext>
    {
        private readonly YouTubeService _youTubeService;

        public YoutubeModule(YouTubeService service)
        {
            _youTubeService = service;
        }

        [Command("yt")]
        [Summary("YouTube search")]
        public Task Search(params string[] query)
        {
            var search = string.Join(" ", query);

            return Search(search);
        }

        [Command("rp2yt")]
        [Summary("Does a youtube search for whatever you/someone else is currently listening to.")]
        public Task Rp2Yt(IUser? user = null)
        {
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

                return Search(songTitle);
            }

            return Task.CompletedTask;
        }

        public Task Search(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return Task.CompletedTask;

            SearchResource.ListRequest listRequest = _youTubeService.Search.List("snippet");
            listRequest.MaxResults = 1;
            listRequest.Q = search;
            listRequest.Type = "video";

            SearchListResponse resp = listRequest.Execute();

            if (resp.Items.Any())
                return ReplyAsync($"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}");
            else
                return Task.CompletedTask;
        }
    }
}
