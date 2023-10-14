using Discord.Interactions;
using Saber.Bot.Commands.Attributes;
using Saber.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Saber.Common;

namespace Saber.Bot.Commands.Interactions
{
    [Group("openai", "OpenAI API shenanigans")]
    public class OpenAiModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly Config _config;
        private readonly OpenAiService _openAiService;

        public OpenAiModule(Config config, OpenAiService openAiService)
        {
            _config = config;
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

            _openAiService.ClearHistory(Context.Guild.Id);

            await FollowupAsync("Chat history cleared.");
        }

        [HasAccessFlag(Database.Models.Profile.AccessRoles.OpenAiImageGen)]
        [SlashCommand("image", "Generate an image")]
        public async Task Image(
            string prompt, 
            [MaxValue(9)] [MinValue(1)]
            int count = 1)
        {
            await DeferAsync();

            var response = (await _openAiService.ImageGen(prompt, count, Context.User) ?? Array.Empty<string>()).ToList();

            if (!response.Any())
            {
                await FollowupAsync("Something went wrong, could not generate images.");
                return;
            }

            string promptText = $"```{prompt}```";

            var files = new List<FileInfo>();

            var taskList = new List<Task>();

            foreach (var x in response)
            {
                var baseDir = _config.TempDir;
                var fileName = $"{Guid.NewGuid()}.png";
                var filePath = System.IO.Path.Combine(baseDir.FullName, fileName);

                files.Add(new FileInfo(filePath));

                var bytes = Convert.FromBase64String(x);
                File.WriteAllBytes(filePath, bytes);
            }

            await Task.WhenAll(taskList);

            var chunkedFiles = Helpers.ChunkFilesBySize(files, 8 * 1000 * 1000);

            bool noteSent = false;

            foreach (var chunk in chunkedFiles)
            {
                if (noteSent)
                {
                    await FollowupWithFilesAsync(chunk.Select(x => new FileAttachment(x.FullName, x.Name)));
                }
                else
                {
                    await FollowupWithFilesAsync(chunk.Select(x => new FileAttachment(x.FullName, x.Name)), promptText);
                    noteSent = true;
                }
            }
        }
    }
}
