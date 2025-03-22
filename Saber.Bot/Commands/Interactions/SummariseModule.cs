using Discord;
using Discord.Commands;
using Discord.Interactions;
using Saber.Bot.Core;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Commands.Interactions
{
    public class SummariseCommandModule : ModuleBase<SocketCommandContext>
    {
        public required Config Config { get; set; }
        public required ILogger Logger { get; set; }
        public required ISummaryService Service;

        [Command("summary")]
        [Discord.Commands.Summary("Gets a summary of a link/article")]
        public async Task Summary(string url, int length = 7)
        {
            Uri? uri = new(url);

            if (uri == null)
                return;

            length = Math.Clamp(length, 1, 30);
            
            var resp = await Service.Summarize(url, length);

            if (resp == null || string.IsNullOrWhiteSpace(resp))
            {
                await ReplyAsync($"Couldn't fetch a summary of the URL.");
                return;
            }
            
            if (resp.Length > 2000)
            {
                await ReplyAsync($"The summary is too long to send. ({resp.Length} characters)");
                return;
            }

            await ReplyAsync(resp);
        }
    }

    public class SummariseInteractionModule : InteractionModule<SocketInteractionContext>
    {
        private readonly ISummaryService _service;

        public SummariseInteractionModule(ISummaryService service)
        {
            _service = service;
        }

        [SlashCommand("summarise", "Gets a summary of a link/article/youtube video")]
        public async Task Summarise(
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

            length = Math.Clamp(length, 1, 30);
            
                var resp = await _service.Summarize(url, length);
            
            if (resp == null || string.IsNullOrWhiteSpace(resp))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }

            await FollowupAsyncTooLong(resp);
        }

        [MessageCommand("Summarise")]
        public async Task Summarise(IMessage message)
        {
            var urls = Helpers.GetUrls(message.Content);

            if (!urls.Any())
            {
                await FollowupAsync("No URLs found in message.", ephemeral: true);
                return;
            }

            await DeferAsync();

            var url = urls.First();

            var resp = await _service.Summarize(url, 7);
            
            if (resp == null || string.IsNullOrWhiteSpace(resp))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }
            
            await FollowupAsyncTooLong(resp);
        }
    }
}
