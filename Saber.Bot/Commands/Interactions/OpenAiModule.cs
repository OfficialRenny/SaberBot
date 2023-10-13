using Discord.Interactions;
using Saber.Bot.Commands.Attributes;
using Saber.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Interactions
{
    [Group("openai", "OpenAI API shenanigans")]
    public class OpenAiModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly OpenAiService _openAiService;

        public OpenAiModule(OpenAiService openAiService)
        {
            _openAiService = openAiService;
        }

        [HasAccessFlag(Database.Models.Profile.AccessRoles.OpenAiTextGen)]
        [SlashCommand("chat", "Chat with the bot")]
        public async Task Ask(string question)
        {
            await DeferAsync();

            var response = await _openAiService.Ask(question, Context.User, Context.Guild);

            await FollowupAsync(response);
        }

        [HasAccessFlag(Database.Models.Profile.AccessRoles.OpenAiTextGen)]
        [SlashCommand("clear-history", "Wipes ChatGPT's memory of this server and starts a fresh conversation.")]
        public async Task ClearHistory()
        {
            await DeferAsync();

            var success = _openAiService.ClearHistory(Context.Guild.Id);

            await FollowupAsync("Chat history cleared.");
        }

        [HasAccessFlag(Database.Models.Profile.AccessRoles.OpenAiImageGen)]
        [SlashCommand("image", "Generate an image")]
        public async Task Image(string prompt)
        {
            await DeferAsync();

            var response = await _openAiService.ImageGen(prompt, 1, Context.User);

            if (response == null || !response.Any())
            {
                await FollowupAsync("Something went wrong, could not generate images.");
                return;
            }

            var embed = new Discord.EmbedBuilder()
                .WithColor(Discord.Color.DarkBlue)
                .WithDescription($"Prompt: {prompt}")
                .WithImageUrl(response.First())
                .Build();
            

            await FollowupAsync(embed: embed);
        }
    }
}
