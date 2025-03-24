using System.Diagnostics;
using NetCord;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Extensions;
using Saber.Common.Services.Interfaces;

namespace SaberBot.Commands.Interactions;

public class BasicTextSlashCommandModule(
    Config config,
    ILogger logger)
    : InteractionModule<ApplicationCommandContext>(config, logger)
{
    //private readonly OneLinerService OneLinerService;

    [SlashCommand("id", "Fetch either your own or a pinged user's ID")]
    public Task Id(
        [SlashCommandParameter(Name = "user", Description = "Fetch this user's ID, leave blank for your own.")]
        User? user = null)
    {
        user ??= Context.User;
        return RespondAsync($"{user.GetDisplayName()}'s ID is {user.Id}");
    }

    [SlashCommand("8ball", "Ask the magic 8-ball a question.")]
    public Task EightBall(
        [SlashCommandParameter(Name = "question")]
        string question)
    {
        return RespondAsync(Helpers.EightBallResponses[Helpers.Random.Next(0, Helpers.EightBallResponses.Length)]);
    }

    [SlashCommand("blocky", "Converts text to blocky text")]
    public Task BlockyText(
        [SlashCommandParameter(Name = "text")] string textToBlockify)
    {
        return RespondAsync(Helpers.StringToRegionalIndicators(textToBlockify));
    }

    [SlashCommand("chance", "Give it a percentage and the bot will decide whether you suceed or fail.")]
    public Task NumberChance(
        [SlashCommandParameter(Name = "percentage")]
        int i)
    {
        if (i < 1 || i > 100)
            return RespondAsync("Please choose a number between 1 and 100.");

        if (Helpers.Random.Next(0, 101) > i)
            return RespondAsync($"Your {i}% chance has failed.");
        return RespondAsync($"Your {i}% chance has succeeded.");
    }

    [SlashCommand("coinflip", "Just a simple coinflip.")]
    public Task Coinflip()
    {
        if (Helpers.Random.NextDouble() < 0.5)
            return RespondAsync("You flipped a coin and it landed on Heads.");
        return RespondAsync("You flipped a coin and it landed on Tails.");
    }

    [SlashCommand("ping", "Pong, check's the bots latency.")]
    public async Task Pong()
    {
        await RespondAsync($"Pong! Latency: {Context.Client.Latency.TotalMilliseconds}ms");
    }

    [SlashCommand("uptime", "Check's the bots uptime.")]
    public Task Uptime()
    {
        return RespondAsync(
            $"I've been up since <t:{(int)(Process.GetCurrentProcess().StartTime.ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds}:R>.");
    }

    [SlashCommand("roll", "Rolls dice.")]
    public Task RollDice(
        [SlashCommandParameter(MinValue = 1)] int diceSize,
        [SlashCommandParameter(MinValue = 1)] int diceCount = 1)
    {
        return RespondAsync($"You rolled {string.Join(", ", Helpers.DiceRoll(diceSize, diceCount))}.");
    }

    // [SlashCommand("oneliner", "Searches for a one-liner gif (https://github.com/ThirteenAG/GTA-One-Liners/)")]
    // public async Task OneLiner(
    //     [Summary("Search", "The search term to use.")] string searchTerm,
    //     OneLinerSource? source = null
    //     )
    // {
    //     await DeferAsync();
    //
    //     var oneLiner = OneLinerService.FindQuote(searchTerm, source);
    //
    //     var url = oneLiner.ImgurLink;
    //     if (string.IsNullOrEmpty(url))
    //         url = oneLiner.DiscordLink;
    //
    //     var embed = new EmbedBuilder()
    //         .WithImageUrl(url)
    //         .WithFooter(oneLiner.Quote)
    //         .Build();
    //
    //     await FollowupAsync(embeds: new[] { embed });
    // }
}