using Discord;
using Discord.Commands;
using Discord.Interactions;
using RestSharp;
using Saber.Bot.Commands.Models;
using Saber.Bot.Core;
using Saber.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Interactions
{
    public class SmmryCommandModule : ModuleBase<SocketCommandContext>
    {
        private readonly Config _config;
        private readonly RestClient _client;
        public SmmryCommandModule(Config config, HttpClient httpClient)
        {
            _config = config;
            _client = new RestClient(httpClient, options: new RestClientOptions
            {
                BaseUrl = new Uri("https://api.smmry.com"),
            });
        }

        [Command("smmry")]
        [Discord.Commands.Summary("Gets a summary of an article, powered by Smmry")]
        public Task Smmry(string url, int length = 7)
        {
            Uri? uri = new(url);

            if (uri == null)
                return Task.CompletedTask;

            object parameters = new
            {
                SM_API_KEY = _config["SmmryKey"],
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

    public class SmmryInteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly Config _config;

        private readonly RestClient _client;

        public SmmryInteractionModule(Config config, HttpClient httpClient)
        {
            _config = config;
            _client = new RestClient(httpClient, options: new RestClientOptions
            {
                BaseUrl = new Uri("https://api.smmry.com"),
            });
        }

        [SlashCommand("smmry", "Gets a summary of an article, powered by Smmry")]
        public async Task Smmry(
            [Discord.Interactions.Summary("url", "Article URL")] string url,
            [Discord.Interactions.Summary("paragraphs", "Number of paragraphs to fetch.")] int length = 7)
        {
            Uri? uri = new(url);

            if (uri == null)
            {
                await RespondAsync("Unable to parse the URL as a valid URL");
                return;
            }

            await DeferAsync();

            var resp = await GetSmmry(url, length);

            if (resp != null && !string.IsNullOrWhiteSpace(resp.Content))
            {
                string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
                await FollowupAsync($"```{title}{resp.Content}```");
                return;
            }

            await FollowupAsync($"Couldn't fetch a summary of the URL.");
            return;
        }

        [MessageCommand("SMMRY")]
        public async Task Smmry(IMessage message)
        {
            var urls = Helpers.GetUrls(message.Content);

            if (!urls.Any())
            {
                await FollowupAsync("No URLs found in message.", ephemeral: true);
                return;
            }

            await DeferAsync();

            var url = urls.First();

            var resp = await GetSmmry(url);

            if (resp != null && !string.IsNullOrWhiteSpace(resp.Content))
            {
                string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
                await FollowupAsync($"```{title}{resp.Content}```");
                return;
            }

            await FollowupAsync($"Couldn't fetch a summary of the URL.");
            return;
        }

        public async Task<SmmryResponse?> GetSmmry(string url, int? length = null)
        {
            Uri? uri = new(url);

            if (uri == null)
                return null;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "SM_API_KEY",  _config["SmmryKey"] },
                { "SM_URL",  url },
            };

            if (length != null)
                parameters.Add("SM_LENGTH", length.Value);

            return await _client.GetJsonAsync<SmmryResponse>("/", parameters);

        }
    }
}
