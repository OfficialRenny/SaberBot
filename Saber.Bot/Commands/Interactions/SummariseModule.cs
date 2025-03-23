using NetCord;
using NetCord.Gateway;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using NetCord.Services.Commands;
using Saber.Bot.Core;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Commands.Interactions
{
    public class SummariseCommandModule(ISummaryService service) : MessageCommandModule<CommandContext>
    {
        [Command("summary")]
        public async Task Summary(string url, int length = 7)
        {
            Uri.TryCreate(url, UriKind.Absolute, out Uri? uri);
            
            if (uri == null)
            {
                await ReplyAsync("Unable to parse the URL as a valid URL");
                return;
            }
            
            length = Math.Clamp(length, 1, 30);
            
            var resp = await service.Summarize(url, length);

            if (string.IsNullOrWhiteSpace(resp))
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

    public class SummariseInteractionModule(ISummaryService service) : InteractionModule<ApplicationCommandContext>
    {
        [SlashCommand("summarise", "Gets a summary of a link/article/youtube video")]
        public async Task Summarise(
            [SlashCommandParameter( Name = "url", Description = "Article URL")] string url,
            [SlashCommandParameter( Name = "paragraphs", Description = "Number of paragraphs to fetch.", MinValue = 1, MaxValue = 15)] int length = 7)
        {
            Uri.TryCreate(url, UriKind.Absolute, out Uri? uri);

            if (uri == null)
            {
                await RespondAsync("Unable to parse the URL as a valid URL");
                return;
            }

            await DeferAsync();

            length = Math.Clamp(length, 1, 15);
            
            var resp = await service.Summarize(url, length);
            
            if (string.IsNullOrWhiteSpace(resp))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }

            await FollowupAsyncTooLong(resp);
        }

        [MessageCommand("Summarise")]
        public async Task Summarise(RestMessage message)
        {
            var urls = Helpers.GetUrls(message.Content).ToList();

            if (urls.Count == 0)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "No URLs found in message.",
                    Flags = MessageFlags.Ephemeral
                });
                return;
            }

            await DeferAsync();

            var url = urls.First();

            var resp = await service.Summarize(url, 7);
            
            if (string.IsNullOrWhiteSpace(resp))
            {
                await FollowupAsync($"Couldn't fetch a summary of the URL.");
                return;
            }
            
            await FollowupAsyncTooLong(resp);
        }
    }
}
