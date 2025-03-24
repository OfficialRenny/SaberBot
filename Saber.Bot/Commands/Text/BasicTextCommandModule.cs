using System.Diagnostics;
using NetCord;
using NetCord.Rest;
using NetCord.Services.Commands;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Extensions;

namespace Saber.Bot.Commands.Text;

public class BasicTextCommandModule : MessageCommandModule<CommandContext>
{
    [Command("id")]
    public Task Id(User? user = null)
    {
        user ??= Context.User;
        return ReplyAsync($"{user.GetDisplayName()}'s ID is {user.Id}");
    }

    [Command("8ball")]
    public Task EightBall(string question)
    {
        return ReplyAsync(Helpers.EightBallResponses[Helpers.Random.Next(0, Helpers.EightBallResponses.Length)]);
    }

    [Command("blocky")]
    public Task BlockyText(string textToBlockify)
    {
        return ReplyAsync(Helpers.StringToRegionalIndicators(textToBlockify));
    }

    [Command("chance")]
    public Task NumberChance(int i)
    {
        if (i < 1 || i > 100)
            return ReplyAsync("Please choose a number between 1 and 100.");

        if (Helpers.Random.Next(0, 101) > i)
            return ReplyAsync($"Your {i}% chance has failed.");
        return ReplyAsync($"Your {i}% chance has succeeded.");
    }

    [Command("coinflip")]
    public Task Coinflip()
    {
        if (Helpers.Random.NextDouble() < 0.5)
            return ReplyAsync("You flipped a coin and it landed on Heads.");
        return ReplyAsync("You flipped a coin and it landed on Tails.");
    }

    [Command("ping")]
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
    public Task Uptime()
    {
        return ReplyAsync(
            $"I've been up since <t:{(int)(Process.GetCurrentProcess().StartTime.ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds}:R>.");
    }

    [Command("poll")]
    public async Task Poll(int o = 0)
    {
        IEnumerable<ReactionEmojiProperties> m = new List<ReactionEmojiProperties>();

        if (o > 0 && o < 10)
            m = Helpers.NumEmojiArray.Take(o).Select(e => new ReactionEmojiProperties(e));
        else
            m = new List<ReactionEmojiProperties> { new("✅"), new("❎") };

        foreach (var e in m)
            await Context.Message.AddReactionAsync(e);
    }

    [Command("roll")]
    public Task RollDice(string command)
    {
        string[] splitCommand = command.ToLower().Split('d');

        var hasRollCount = int.TryParse(splitCommand[0], out var timesToRoll);
        var hasDieSize = int.TryParse(splitCommand[1], out var dieSize);

        if (hasRollCount && hasDieSize)
            return ReplyAsync($"You rolled {string.Join(", ", Helpers.DiceRoll(dieSize, timesToRoll))}.");

        return ReplyAsync("Please choose a number of dice to roll. `SYNTAX: roll 1d20`.");
    }
}