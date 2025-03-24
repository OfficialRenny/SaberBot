using System.Text;
using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;
using WarframeMarket.Model;
using static Saber.Common.Services.WarframeService;

namespace Saber.Bot.Commands.Interactions;

[SlashCommand("warframe", "Warframe Commands")]
public class WarframeModule(
    Config config,
    ILogger logger,
    WarframeService warframeService)
    : InteractionModule<ApplicationCommandContext>(config, logger)
{
    [SubSlashCommand("market", "Warframe Market Commands")]
    public class MarketModule(
        Config config,
        ILogger logger,
        WarframeService warframeService)
        : InteractionModule<ApplicationCommandContext>(config, logger)
    {
        [SubSlashCommand("item", "Search for an item on Warframe Market")]
        public async Task ItemSearchAsync(
            [SlashCommandParameter(Name = "query", Description = "The item to search for",
                AutocompleteProviderType = typeof(WarframeItemAutocompleteHandler))]
            string query,
            [SlashCommandParameter(Name = "count", Description = "The number of results to return", MinValue = 1)]
            int count = 1)
        {
            await DeferAsync();

            var items = (await warframeService.SearchIndex<ItemShort>(query, count)).ToList();
            if (!items.Any())
            {
                await FollowupAsync("No results found.");
                return;
            }

            if (items.Count > 1)
            {
                var embed = new EmbedProperties()
                    .WithColor(new Color(0x800080))
                    .WithTitle($"Search results for {query}")
                    .WithDescription($"Found {items.Count()} results")
                    .WithFields(
                        items.Select(x => new EmbedFieldProperties()
                            .WithName($"{x.ItemName} (id: {x.UrlName})")
                            .WithValue($"[View](https://warframe.market/items/{x.UrlName})")
                            .WithInline(false)));

                await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
            }
            else
            {
                var item = items.First();

                var fullItemInfo = await warframeService.GetFullItemDataAsync(item.UrlName);
                var it = fullItemInfo.Item;

                var embed = new EmbedProperties();
                embed.WithColor(new Color(0x800080));
                embed.WithTitle(it.En.ItemName);
                embed.WithDescription(it.En.Description);
                embed.WithUrl($"https://warframe.market/items/{it.UrlName}");
                embed.WithThumbnail(warframeService.ResolveAssetUrl(item.Thumb));
                embed.WithFooter(
                    new EmbedFooterProperties().WithText(
                        $"Data last fetched: {fullItemInfo.FetchTime:yyyy-MM-dd HH:mm:ss} UTC"));
                if (!string.IsNullOrEmpty(it.En.WikiLink))
                    embed.AddField("Wiki Page", $"[Click here to view on the Warframe Wiki]({it.En.WikiLink})");

                embed.AddField("Item Info", "General Item Info");
                embed.AddField("Mastery Requirement", it.MasteryLevel > 0 ? it.MasteryLevel.ToString() : "None", true);
                if (!string.IsNullOrEmpty(it.Rarity.ToString()))
                    embed.AddField("Rarity", it.Rarity.ToString(), true);
                if (it.Ducats > 0)
                    embed.AddField("Ducats", it.Ducats.ToString(), true);
                if (item.Vaulted == true)
                    embed.AddField("Vaulted", "Yes", true);

                embed.AddField("Trading Info", "Prices, Trading Tax, etc.");
                var minSellPrice = warframeService.GetMinPrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);
                var avgSellPrice = warframeService.GetAveragePrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);
                var maxSellPrice = warframeService.GetMaxPrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);

                var minBuyPrice = warframeService.GetMinPrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);
                var avgBuyPrice = warframeService.GetAveragePrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);
                var maxBuyPrice = warframeService.GetMaxPrice(fullItemInfo.Orders,
                    ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);

                embed.AddField("Sell Prices", $"Min: {minSellPrice}\nAvg: {avgSellPrice}\nMax: {maxSellPrice}", true);
                embed.AddField("Buy Prices", $"Min: {minBuyPrice}\nAvg: {avgBuyPrice}\nMax: {maxBuyPrice}", true);
                embed.AddField("Trading Tax", it.TradingTax.ToString(), true);

                if (fullItemInfo.Dropsources != null && fullItemInfo.Dropsources.Any())
                {
                    var missions = new List<(decimal, EmbedFieldProperties)>();
                    var relics = new List<EmbedFieldProperties>();
                    var npcs = new List<EmbedFieldProperties>();

                    foreach (var source in fullItemInfo.Dropsources)
                        switch (source.ActualInstance)
                        {
                            case DropsourceMission dsMission:
                            {
                                var resolvedMission = warframeService.ResolveMission(dsMission.Mission);
                                var resolvedLocation = warframeService.ResolveLocation(dsMission.Location);
                                if (resolvedMission == null || resolvedLocation == null)
                                    continue;

                                // consider nullables when displaying range
                                var levelRangeString =
                                    $"{resolvedLocation.MinLevel}{(resolvedLocation.MinLevel.HasValue && resolvedLocation.MaxLevel.HasValue ? " - " : "")}{resolvedLocation.MaxLevel}";

                                var desc = new StringBuilder();
                                desc.AppendLine(
                                    $"Location: {resolvedLocation.NodeName} - {resolvedLocation.SystemName} {(!string.IsNullOrWhiteSpace(levelRangeString) ? $"(Lvl. {levelRangeString})" : "")}");
                                if (dsMission.VarEvent == true)
                                    desc.AppendLine("Event: Yes");
                                if (dsMission.Rotation.HasValue)
                                    desc.AppendLine($"Rotation: {dsMission.Rotation}");
                                if (dsMission.Stage != null && dsMission.Stage.Any())
                                    desc.AppendLine($"Stage: {string.Join(", ", dsMission.Stage)}");
                                desc.AppendLine($"Rarity: {dsMission.Rarity}");
                                desc.AppendLine($"Rate: {dsMission.Rate}%");

                                missions.Add((dsMission.Rate,
                                    new EmbedFieldProperties()
                                        .WithName(resolvedMission.Name)
                                        .WithValue(desc.ToString())
                                        .WithInline()));
                                break;
                            }
                            case DropsourceRelic relic:
                            {
                                var itemShort = warframeService.Resolve<ItemShort>(relic.Relic);
                                if (itemShort == null)
                                    continue;

                                var desc = new StringBuilder();
                                desc.AppendLine($"Intact: {relic.Rates.Intact}%");
                                desc.AppendLine($"Radiant: {relic.Rates.Radiant}%");
                                desc.AppendLine($"Flawless: {relic.Rates.Flawless}%");
                                desc.AppendLine($"Exceptional: {relic.Rates.Exceptional}%");
                                desc.AppendLine($"Rarity: {relic.Rarity}");

                                relics.Add(new EmbedFieldProperties()
                                    .WithName($"{itemShort.ItemName}{(itemShort.Vaulted == true ? " (Vaulted)" : "")}")
                                    .WithValue(desc.ToString()).WithInline());
                                break;
                            }
                            case DropsourceNpc npc:
                            {
                                var resolvedNpc = warframeService.Resolve<Npc>(npc.Npc);
                                if (resolvedNpc == null)
                                    continue;

                                var desc = new StringBuilder();
                                desc.AppendLine($"Rate: {npc.Rate}%");
                                desc.AppendLine($"Rarity: {npc.Rarity}");

                                npcs.Add(new EmbedFieldProperties().WithName(resolvedNpc.Name)
                                    .WithValue(desc.ToString()).WithInline());
                                break;
                            }
                        }

                    if (missions.Count != 0)
                    {
                        var canShowMore = missions.Count > 3;
                        var total = missions.Count;
                        missions = missions.OrderBy(x => x.Item1).ThenBy(x => x.Item2.Name).Take(3).ToList();
                        embed.AddField("Drop Sources",
                            $"Missions{(canShowMore ? $" - First 3 (out of {total})" : "")}");
                        foreach (var missionGroup in missions)
                            embed.AddField(missionGroup.Item2);
                    }

                    if (relics.Count != 0)
                    {
                        var canShowMore = relics.Count > 3;
                        var total = relics.Count;
                        relics = relics.OrderBy(x => x.Name).Take(3).ToList();
                        embed.AddField("Drop Sources", $"Relics{(canShowMore ? $" - First 3 (out of {total})" : "")}");
                        foreach (var field in relics)
                            embed.AddField(field);

                        if (fullItemInfo.Dropsources.Where(x => x.ActualInstance is DropsourceRelic).All(x =>
                                warframeService.Resolve<ItemShort>(x.GetDropsourceRelic().Id)?.Vaulted == true))
                            embed.WithTitle($"{it.En.ItemName} (Vaulted)");
                    }

                    if (npcs.Any())
                    {
                        var canShowMore = npcs.Count > 3;
                        var total = npcs.Count;
                        npcs = npcs.OrderBy(x => x.Name).Take(3).ToList();
                        embed.AddField("Drop Sources", $"NPCs{(canShowMore ? $" - First 3 (out of {total})" : "")}");
                        foreach (var field in npcs)
                            embed.AddField(field);
                    }
                }

                if (fullItemInfo.ItemsInSet.Any(x => x.UrlName != it.UrlName))
                {
                    embed.AddField("Set Info", "Items in Set");
                    foreach (var itemInSet in fullItemInfo.ItemsInSet.Where(x => x.UrlName != it.UrlName))
                        embed.AddField(itemInSet.En.ItemName, itemInSet.UrlName, true);
                }

                if (fullItemInfo.Item.Tags.Count != 0)
                    embed.AddField("Tags", string.Join(", ", fullItemInfo.Item.Tags));

                await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
            }
        }

        [SubSlashCommand("dropsources", "Shows drop sources for an item")]
        public async Task Dropsources(
            [SlashCommandParameter(Name = "query", Description = "The item to search for")]
            string query,
            [SlashCommandParameter(Name = "type", Description = "Drop Source Type")]
            DropsourceType type)
        {
            await DeferAsync();

            var item = await warframeService.SearchIndex<ItemShort>(query);
            if (item == null)
            {
                await FollowupAsync("Item not found");
                return;
            }

            var fullItemData = await warframeService.GetFullItemDataAsync(item.UrlName);
            if (fullItemData == null)
            {
                await FollowupAsync("Item not found");
                return;
            }

            if (fullItemData.Dropsources == null || !fullItemData.Dropsources.Any())
            {
                await FollowupAsync($"Unable to find any drop sources for {item.ItemName}");
                return;
            }

            var embed = new EmbedProperties()
                .WithTitle($"{item.ItemName} - Drop Sources")
                .WithUrl($"https://warframe.fandom.com/wiki/{item.UrlName}")
                .WithThumbnail(warframeService.ResolveAssetUrl(item.Thumb))
                .WithColor(new Color(0x800080));

            switch (type)
            {
                case DropsourceType.Relic:
                    var relics = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceRelic)
                        .Select(x => x.GetDropsourceRelic()).ToList();
                    var relicItems = relics.Select(x => warframeService.Resolve<ItemShort>(x.Relic))
                        .Where(x => x != null).ToList();
                    // order relicItems by not vaulted first, then by name
                    relicItems = relicItems.OrderBy(x => x?.Vaulted.GetValueOrDefault()).ThenBy(x => x?.ItemName)
                        .Take(21).ToList();
                    if (relicItems.Count == 0)
                    {
                        await FollowupAsync($"Unable to find any relic drop sources for {item.ItemName}");
                        return;
                    }

                    foreach (var relicItem in relicItems)
                    {
                        var relic = relics.FirstOrDefault(x => x.Relic == relicItem?.Id);
                        if (relic == null)
                            continue;

                        var desc = new StringBuilder();
                        desc.AppendLine($"Intact: {relic.Rates.Intact}");
                        desc.AppendLine($"Radiant: {relic.Rates.Radiant}");
                        desc.AppendLine($"Flawless: {relic.Rates.Flawless}");
                        desc.AppendLine($"Exceptional: {relic.Rates.Exceptional}");
                        desc.AppendLine($"Rarity: {relic.Rarity}");

                        embed.AddField($"{relicItem?.ItemName}{(relicItem?.Vaulted == true ? " (Vaulted)" : "")}",
                            desc.ToString(), true);
                    }

                    await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
                    return;
                case DropsourceType.Mission:
                    var missions = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceMission)
                        .Select(x => x.GetDropsourceMission()).ToList();
                    if (missions.Count == 0)
                    {
                        await FollowupAsync($"Unable to find any mission drop sources for {item.ItemName}");
                        return;
                    }

                    var resolvedMissions = missions.Select(x => warframeService.ResolveMission(x.Mission))
                        .Where(x => x != null).ToList();
                    missions = missions.OrderByDescending(x => x.Rate).Take(21).ToList();
                    foreach (var mission in missions)
                    {
                        var resolvedMission = resolvedMissions.FirstOrDefault(x => x.Id == mission.Mission);
                        var resolvedLocation = warframeService.ResolveLocation(mission.Location);
                        if (resolvedMission == null || resolvedLocation == null)
                            continue;

                        var levelRangeString =
                            $"{resolvedLocation.MinLevel}{(resolvedLocation.MinLevel.HasValue && resolvedLocation.MaxLevel.HasValue ? " - " : "")}{resolvedLocation.MaxLevel}";

                        var desc = new StringBuilder();
                        desc.AppendLine(
                            $"Location: {resolvedLocation.NodeName} - {resolvedLocation.SystemName} {(!string.IsNullOrWhiteSpace(levelRangeString) ? $"(Lvl. {levelRangeString})" : "")}");
                        if (mission.VarEvent == true)
                            desc.AppendLine("Event: Yes");
                        if (mission.Rotation.HasValue)
                            desc.AppendLine($"Rotation: {mission.Rotation}");
                        if (mission.Stage != null && mission.Stage.Any())
                            desc.AppendLine($"Stage: {string.Join(", ", mission.Stage)}");
                        desc.AppendLine($"Rarity: {mission.Rarity}");
                        desc.AppendLine($"Rate: {mission.Rate}%");

                        embed.AddField(resolvedMission.Name, desc.ToString(), true);
                    }

                    await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
                    return;
                case DropsourceType.Npc:
                    var npcs = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceNpc)
                        .Select(x => x.GetDropsourceNpc()).ToList();
                    if (npcs.Count == 0)
                    {
                        await FollowupAsync($"Unable to find any NPC drop sources for {item.ItemName}");
                        return;
                    }

                    npcs = npcs.OrderByDescending(x => x.Rate).Take(21).ToList();
                    foreach (var npc in npcs)
                    {
                        var resolvedNpc = warframeService.Resolve<Npc>(npc.Npc);
                        if (resolvedNpc == null)
                            continue;

                        var desc = new StringBuilder();
                        desc.AppendLine($"Rate: {npc.Rate}%");
                        desc.AppendLine($"Rarity: {npc.Rarity}");

                        embed.AddField(resolvedNpc.Name, desc.ToString(), true);
                    }

                    await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
                    return;
                default:
                    await FollowupAsync("Invalid drop source type");
                    return;
            }
        }
    }
}