using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using NetCord;
using NetCord.Gateway;
using NetCord.Services.Commands;
using Saber.Bot.Core.Extensions;

namespace Saber.Bot.Commands.Text
{
    public class YoutubeModule(YouTubeService service) : MessageCommandModule<CommandContext>
    {
        [Command("yt")]
        public Task Search(params string[] query)
        {
            var search = string.Join(" ", query);

            return Search(search);
        }

        [Command("rp2yt")]
        public async Task Rp2Yt(User? user = null)
        {
            user ??= Context.User;

            var userPresence = Context.Client.Cache.Guilds.SelectMany(x => x.Value.Presences).Where(x => x.Value.User.Id == user.Id).Select(x => x.Value).FirstOrDefault();
            if (userPresence == null)
            {
                await ReplyAsync($"Could not presence status for {user.Username}.");
                return;
            }
            
            var musicPresences = userPresence.Activities.Where(n => n.Type == UserActivityType.Listening).ToList();
            if (musicPresences.Count != 0)
            {
                var cur = musicPresences.First();
                var songTitle = "";
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
                return ReplyAsync("Task failed successfully. (Search was empty.)");

            SearchResource.ListRequest listRequest = service.Search.List("snippet");
            listRequest.MaxResults = 3;
            listRequest.Q = search;
            listRequest.Type = "video";

            SearchListResponse resp = listRequest.Execute();

            return ReplyAsync(resp.Items.Any() ? $"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}" : "Task failed successfully. (Couldn't find any search results for some reason...)");
        }
    }
}
