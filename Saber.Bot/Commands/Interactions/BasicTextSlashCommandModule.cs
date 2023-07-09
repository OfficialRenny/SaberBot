using Discord;
using Discord.Interactions;
using Saber.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SaberBot.Commands.Interactions
{
    public class BasicTextSlashCommandModule : InteractionModuleBase<SocketInteractionContext>
    {
        [SlashCommand("id", "Fetch either your own or a pinged user's ID")]
        public Task Id(
            [Summary("User", "Fetch this user's ID, leave blank for your own.")] IUser? user = null)
        {
            user ??= Context.User;
            return RespondAsync($"{user.Username}'s ID is {user.Id}");
        }

        [SlashCommand("8ball", "Ask the magic 8-ball a question.")]
        public Task EightBall(
            [Summary("Question")] string question)
        {
            return RespondAsync(Helpers.EightBallResponses[Helpers.Random.Next(0, Helpers.EightBallResponses.Length)]);
        }

        [SlashCommand("blocky", "Converts text to blocky text")]
        public Task BlockyText(
            [Summary("Text")] string textToBlockify)
        {
            return RespondAsync(Helpers.StringToRegionalIndicators(textToBlockify));
        }

        [SlashCommand("chance", "Give it a percentage and the bot will decide whether you suceed or fail.")]
        public Task NumberChance(
            [Summary("Percentage")] int i)
        {
            if (i < 1 || i > 100)
                return RespondAsync("Please choose a number between 1 and 100.");

            if (Helpers.Random.Next(0, 101) > i)
                return RespondAsync($"Your {i}% chance has failed.");
            else
                return RespondAsync($"Your {i}% chance has succeeded.");
        }

        [SlashCommand("coinflip", "Just a simple coinflip.")]
        public Task Coinflip()
        {
            if (Helpers.Random.NextDouble() < 0.5)
                return RespondAsync("You flipped a coin and it landed on Heads.");
            else
                return RespondAsync("You flipped a coin and it landed on Tails.");
        }

        [SlashCommand("ping", "Pong, check's the bots latency.")]
        public async Task Pong()
            => await RespondAsync(text: $"Pong! Latency: {Context.Client.Latency}ms");

        [SlashCommand("uptime", "Check's the bots uptime.")]
        public Task Uptime()
        {
            return RespondAsync($"I've been up since <t:{(int)(Process.GetCurrentProcess().StartTime.ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds}:R>.");
        }

        [SlashCommand("roll", "Rolls dice.")]
        public Task RollDice([MinValue(1)] int diceSize, [MinValue(1)] int diceCount = 1)
        {
            return RespondAsync($"You rolled {string.Join(", ", Helpers.DiceRoll(diceSize, diceCount))}.");
        }
    }
}
