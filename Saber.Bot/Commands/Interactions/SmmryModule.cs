using Discord;
using Discord.Commands;
using Discord.Interactions;
using RestSharp;
using Saber.Bot.Core;
using Saber.Common;
using Saber.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Interactions
{
    public class SmmryCommandModule : ModuleBase<SocketCommandContext>
    {
        private readonly SmmryService _service;
        public SmmryCommandModule(SmmryService service)
        {
            _service = service;
        }

        [Command("smmry")]
        [Discord.Commands.Summary("Gets a summary of an article, powered by Smmry")]
        public async Task Smmry(string url, int length = 7)
        {
            Uri? uri = new(url);

            if (uri == null)
                return;

            var resp = await _service.GetSmmry(url, length);

            if (resp == null || string.IsNullOrWhiteSpace(resp.Content))
            {
                await ReplyAsync($"Couldn't fetch a summary of the URL.");
                return;
            }

            string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
            var reply = $"```{title}{resp.Content}```";

            if (reply.Length > 2000)
            {
                await ReplyAsync($"The summary is too long to send. ({reply.Length} characters)");
                return;
            }

            await ReplyAsync(reply);
        }
    }

    public class SmmryInteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly SmmryService _service;
        public SmmryInteractionModule(SmmryService service)
        {
            _service = service;
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

            var resp = await _service.GetSmmry(url, length);

            if (resp == null || string.IsNullOrWhiteSpace(resp.Content))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }

            string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
            var reply = $"```{title}{resp.Content}```";

            if (reply.Length > 2000)
            {
                await FollowupAsync($"The summary is too long to send. ({reply.Length} characters)");
                return;
            }

            await FollowupAsync(reply);
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

            var resp = await _service.GetSmmry(url);

            if (resp == null || string.IsNullOrWhiteSpace(resp.Content))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }

            string title = string.IsNullOrWhiteSpace(resp.Title) ? string.Empty : resp.Title + "\n\n";
            var reply = $"```{title}{resp.Content}```";

            if (reply.Length > 2000)
            {
                await FollowupAsync($"The summary is too long to send. ({reply.Length} characters)");
                return;
            }

            await FollowupAsync(reply);
        }
    }
}
