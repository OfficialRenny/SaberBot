using Discord;
using Discord.Commands;
using RestSharp;
using SaberBot.Commands.Models;
using SaberBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Commands
{
    public class SmmryModule : ModuleBase<SocketCommandContext>
    {
        private readonly RestClient _client;
        public SmmryModule(HttpClient httpClient)
        {
            _client = new RestClient(httpClient, options: new RestClientOptions
            {
                BaseUrl = new Uri("https://api.smmry.com"),
            });
        }

        [Command("smmry")]
        [Summary("Gets a summary of an article, powered by Smmry")]
        public Task Smmry(string url, int length = 7)
        {
            Uri? uri = new(url);

            if (uri == null)
                return Task.CompletedTask;

            object parameters = new
            {
                SM_API_KEY = Config.SmmryKey,
                SM_URL = url,
                SM_LENGTH = length,
            };

            var resp = _client.GetJson<SmmryResponse>("/", parameters);

           if (resp != null && !string.IsNullOrWhiteSpace(resp.Content))
           {
               string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
               return ReplyAsync($"```{title}{resp.Content}```");
           }
            
            return Task.CompletedTask;
        }
    }
}
