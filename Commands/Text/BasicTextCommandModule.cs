using Discord;
using Discord.Commands;
using Saber.Bot.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Text
{
    public class BasicTextCommandModule : ModuleBase<SocketCommandContext>
    {
        [Command("id")]
        [Summary("Fetch either your own or a pinged user's ID")]
        public Task Id(IUser? user = null)
        {
            user ??= Context.User;
            return ReplyAsync($"{user.Username}'s ID is {user.Id}");
        }

        [Command("8ball")]
        [Summary("Ask the magic 8-ball a question")]
        public Task EightBall([Remainder] string question)
        {
            return ReplyAsync(Helpers.EightBallResponses[Helpers.Random.Next(0, Helpers.EightBallResponses.Length)]);
        }

        [Command("blocky", true)]
        [Summary("Converts text to blocky text")]
        public Task BlockyText([Remainder] string textToBlockify)
        {
            return ReplyAsync(Helpers.StringToRegionalIndicators(textToBlockify));
        }

        [Command("chance")]
        [Summary("Give it a percentage and the bot will decide whether you suceed or fail.")]
        public Task NumberChance(int i)
        {
            if (i < 1 || i > 100)
                return ReplyAsync("Please choose a number between 1 and 100.");

            if (Helpers.Random.Next(0, 101) > i)
                return ReplyAsync($"Your {i}% chance has failed.");
            else
                return ReplyAsync($"Your {i}% chance has succeeded.");
        }

        [Command("coinflip")]
        [Summary("Just a simple coinflip.")]
        public Task Coinflip()
        {
            if (Helpers.Random.NextDouble() < 0.5)
                return ReplyAsync("You flipped a coin and it landed on Heads.");
            else
                return ReplyAsync("You flipped a coin and it landed on Tails.");
        }

        [Command("ping")]
        [Summary("Pong, check's the bots latency.")]
        public Task Pong()
        {
            var dt = DateTime.Now;
            return Task.Run(async () =>
            {
                var msg = await ReplyAsync("Pong!");
                return msg.ModifyAsync(msg => msg.Content = $"Pong! Latency: {(DateTime.Now - dt).TotalMilliseconds}ms");
            });
        }

        [Command("uptime")]
        [Summary("Check's the bots uptime.")]
        public Task Uptime()
        {
            return ReplyAsync($"I've been up since <t:{(int)(Process.GetCurrentProcess().StartTime.ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds}:R>.");
        }

        [Command("poll", true)]
        [Summary("Create a quick poll with up to 10 options.")]
        public Task Poll(int o = 0)
        {
            IEnumerable<IEmote> m = new List<IEmote>();

            if (o > 0 && o < 10)
                m = Helpers.NumEmojiArray.Take(o).Select(e => new Emoji(e));
            else
                m = new List<IEmote> { new Emoji("✅"), new Emoji("❎") };

            return Context.Message.AddReactionsAsync(m);
        }

        [Command("roll")]
        [Summary("Rolls dice.")]
        public Task RollDice([Remainder] string command)
        {
            string[] splitCommand = command.ToLower().Split('d');

            bool hasRollCount = int.TryParse(splitCommand[0], out int timesToRoll);
            bool hasDieSize = int.TryParse(splitCommand[1], out int dieSize);

            if (hasRollCount && hasDieSize)
            {
                return ReplyAsync($"You rolled {string.Join(", ", Helpers.DiceRoll(dieSize, timesToRoll))}.");
            }
            else
            {
                return ReplyAsync("Please choose a number of dice to roll. `SYNTAX: roll 1d20`.");
            }
        }
    }
}
