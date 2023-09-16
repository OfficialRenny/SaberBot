using Discord;
using Discord.Interactions;
using Google.Apis.YouTube.v3.Data;
using Microsoft.IdentityModel.Tokens;
using Saber.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeMarket.Model;
using static Saber.Common.Services.WarframeService;

namespace Saber.Bot.Commands.Interactions
{
    [Group("warframe", "Warframe Commands")]
    public class WarframeModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly WarframeService _svc;

        public WarframeModule(WarframeService warframeService)
        {
            _svc = warframeService;
        }

        [Group("market", "Warframe Market Commands")]
        public class MarketModule : InteractionModuleBase<SocketInteractionContext>
        {
            private readonly WarframeService _svc;

            public MarketModule(WarframeService warframeService)
            {
                _svc = warframeService;
            }

            [SlashCommand("item", "Search for an item on Warframe Market")]
            public async Task ItemSearchAsync(
            [Summary("query", "The item to search for")] string query,
            [Summary("count", "The number of results to return")] [MinValue(1)] int count = 1)
            {
                await DeferAsync();

                var items = _svc.SearchIndex<ItemShort>(query, count);
                if (items == null || !items.Any())
                {
                    await FollowupAsync("No results found.");
                    return;
                }

                if (items.Count() > 1)
                {
                    var embed = new EmbedBuilder()
                        .WithColor(Discord.Color.Purple)
                        .WithTitle($"Search results for {query}")
                        .WithDescription($"Found {items.Count()} results")
                        .WithFields(
                            items.Select(x => new EmbedFieldBuilder()
                            .WithName($"{x.ItemName} (id: {x.UrlName})")
                            .WithValue($"[View](https://warframe.market/items/{x.UrlName})")
                            .WithIsInline(false)))
                        .Build();

                    await FollowupAsync(embed: embed);
                    return;
                }
                else
                {
                    var item = items.First();

                    var fullItemInfo = await _svc.GetFullItemDataAsync(item.UrlName);
                    var it = fullItemInfo.Item;
                    if (it == null)
                    {
                        await FollowupAsync("No results found.");
                        return;
                    }

                    var embed = new EmbedBuilder();
                    embed.WithColor(Discord.Color.Purple);
                    embed.WithTitle(it.En.ItemName);
                    embed.WithDescription(it.En.Description);
                    embed.WithUrl($"https://warframe.market/items/{it.UrlName}");
                    embed.WithThumbnailUrl(_svc.ResolveAssetUrl(item.Thumb));
                    embed.WithFooter($"Data last fetched: {fullItemInfo.FetchTime.ToString("yyyy-MM-dd HH:mm:ss")} UTC");
                    if (!string.IsNullOrEmpty(it.En.WikiLink))
                        embed.AddField("Wiki Page", $"[Click here to view on the Warframe Wiki]({it.En.WikiLink})");

                    embed.AddField("Item Info", "General Item Info", false);
                        embed.AddField("Mastery Requirement", it.MasteryLevel > 0 ? it.MasteryLevel.ToString() : "None", true);
                    if (!string.IsNullOrEmpty(it.Rarity.ToString()))
                        embed.AddField("Rarity", it.Rarity.ToString(), true);
                    if (it.Ducats > 0)
                        embed.AddField("Ducats", it.Ducats, true);
                    if (item.Vaulted == true)
                        embed.AddField("Vaulted", "Yes", true);

                    embed.AddField("Trading Info", "Prices, Trading Tax, etc.", false);
                    var minSellPrice = _svc.GetMinPrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);
                    var avgSellPrice = _svc.GetAveragePrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);
                    var maxSellPrice = _svc.GetMaxPrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Sell);

                    var minBuyPrice = _svc.GetMinPrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);
                    var avgBuyPrice = _svc.GetAveragePrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);
                    var maxBuyPrice = _svc.GetMaxPrice(fullItemInfo.Orders, WarframeMarket.Model.ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum.Buy);

                    embed.AddField("Sell Prices", $"Min: {minSellPrice}\nAvg: {avgSellPrice}\nMax: {maxSellPrice}", true);
                    embed.AddField("Buy Prices", $"Min: {minBuyPrice}\nAvg: {avgBuyPrice}\nMax: {maxBuyPrice}", true);
                    embed.AddField("Trading Tax", it.TradingTax, true);

                    if (fullItemInfo.Dropsources != null && fullItemInfo.Dropsources.Any())
                    {
                        List<EmbedFieldBuilder> missions = new List<EmbedFieldBuilder>();
                        List<EmbedFieldBuilder> relics = new List<EmbedFieldBuilder>();
                        List<EmbedFieldBuilder> npcs = new List<EmbedFieldBuilder>();

                        foreach (var source in fullItemInfo.Dropsources)
                        {
                            if (source.ActualInstance is DropsourceMission dsMission)
                            {
                                Mission? resolvedMission = _svc.ResolveMission(dsMission.Mission);
                                Location? resolvedLocation = _svc.ResolveLocation(dsMission.Location);
                                if (resolvedMission == null || resolvedLocation == null)
                                    continue;

                                // consider nullables when displaying range
                                var levelRangeString = $"{resolvedLocation.MinLevel}{(resolvedLocation.MinLevel.HasValue && resolvedLocation.MaxLevel.HasValue ? " - " : "")}{resolvedLocation.MaxLevel}";

                                var desc = new StringBuilder();
                                desc.AppendLine($"Location: {resolvedLocation.NodeName} - {resolvedLocation.SystemName} {(!string.IsNullOrWhiteSpace(levelRangeString) ? $"(Lvl. {levelRangeString})" : "")}");
                                if (dsMission.VarEvent == true)
                                    desc.AppendLine($"Event: Yes");
                                if (dsMission.Rotation.HasValue)
                                    desc.AppendLine($"Rotation: {dsMission.Rotation}");
                                if (dsMission.Stage != null && dsMission.Stage.Any())
                                    desc.AppendLine($"Stage: {string.Join(", ", dsMission.Stage)}");
                                desc.AppendLine($"Rarity: {dsMission.Rarity}");
                                desc.AppendLine($"Rate: {dsMission.Rate}%");

                                missions.Add(new EmbedFieldBuilder().WithName(resolvedMission.Name).WithValue(desc.ToString()).WithIsInline(true));
                            }
                            else if (source.ActualInstance is DropsourceRelic relic)
                            {
                                var itemShort = _svc.Resolve<ItemShort>(relic.Relic);
                                if (itemShort == null)
                                    continue;
                                
                                var desc = new StringBuilder();
                                desc.AppendLine($"Intact: {relic.Rates.Intact}");
                                desc.AppendLine($"Radiant: {relic.Rates.Radiant}");
                                desc.AppendLine($"Flawless: {relic.Rates.Flawless}");
                                desc.AppendLine($"Exceptional: {relic.Rates.Exceptional}");
                                desc.AppendLine($"Rarity: {relic.Rarity}");

                                relics.Add(new EmbedFieldBuilder().WithName($"{itemShort.ItemName}{(itemShort.Vaulted == true ? " (Vaulted)" : "")}").WithValue(desc.ToString()).WithIsInline(true));
                            }
                            else if (source.ActualInstance is DropsourceNpc npc)
                            {
                                var resolvedNpc = _svc.Resolve<Npc>(npc.Npc);
                                if (resolvedNpc == null)
                                    continue;

                                var desc = new StringBuilder();
                                desc.AppendLine($"Rate: {npc.Rate}%");
                                desc.AppendLine($"Rarity: {npc.Rarity}");

                                npcs.Add(new EmbedFieldBuilder().WithName(resolvedNpc.Name).WithValue(desc.ToString()).WithIsInline(true));
                            }
                        }

                        if (missions.Any())
                        {
                            var canShowMore = missions.Count > 3;
                            var total = missions.Count;
                            missions = missions.OrderBy(x => x.Name).Take(3).ToList();
                            embed.AddField("Drop Sources", $"Missions{(canShowMore ? $" - First 3 (out of {total})" : "")}", false);
                            foreach (var field in missions)
                                embed.AddField(field);
                        }
                        if (relics.Any())
                        {
                            var canShowMore = relics.Count > 3;
                            var total = relics.Count;
                            relics = relics.OrderBy(x => x.Name).Take(3).ToList();
                            embed.AddField("Drop Sources", $"Relics{(canShowMore ? $" - First 3 (out of {total})" : "")}", false);
                            foreach (var field in relics)
                                embed.AddField(field);

                            if (fullItemInfo.Dropsources.Where(x => x.ActualInstance is DropsourceRelic).All(x => _svc.Resolve<ItemShort>(x.GetDropsourceRelic().Id)?.Vaulted == true))
                                embed.WithTitle($"{it.En.ItemName} (Vaulted)");
                        }
                        if (npcs.Any())
                        {
                            var canShowMore = npcs.Count > 3;
                            var total = npcs.Count;
                            npcs = npcs.OrderBy(x => x.Name).Take(3).ToList();
                            embed.AddField("Drop Sources", $"NPCs{(canShowMore ? $" - First 3 (out of {total})" : "")}", false);
                            foreach (var field in npcs)
                                embed.AddField(field);
                        }
                    }

                    if (fullItemInfo.ItemsInSet.Any(x => x.UrlName != it.UrlName))
                    {
                        embed.AddField("Set Info", "Items in Set", false);
                        foreach (var itemInSet in fullItemInfo.ItemsInSet.Where(x => x.UrlName != it.UrlName))
                        {
                            embed.AddField(itemInSet.En.ItemName, itemInSet.UrlName, true);
                        }
                    }

                    if (fullItemInfo.Item.Tags.Any())
                    {
                        embed.AddField("Tags", string.Join(", ", fullItemInfo.Item.Tags), false);
                    }

                    await FollowupAsync(embed: embed.Build());

                    return;
                }
            }

            [SlashCommand("dropsources", "Shows drop sources for an item")]
            public async Task Dropsources(
                [Summary("query", "The item to search for")] string query,
                [Summary("type", "Drop Source Type")] DropsourceType type)
            {
                await DeferAsync();

                var item = _svc.SearchIndex<ItemShort>(query);
                if (item == null)
                {
                    await FollowupAsync("Item not found");
                    return;
                }

                var fullItemData = await _svc.GetFullItemDataAsync(item.UrlName);
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

                var embed = new EmbedBuilder()
                    .WithTitle($"{item.ItemName} - Drop Sources")
                    .WithUrl($"https://warframe.fandom.com/wiki/{item.UrlName}")
                    .WithThumbnailUrl(_svc.ResolveAssetUrl(item.Thumb))
                    .WithColor(Discord.Color.Purple);

                switch (type)
                {
                    case DropsourceType.Relic:
                        var relics = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceRelic).Select(x => x.GetDropsourceRelic()).ToList();
                        var relicItems = relics.Select(x => _svc.Resolve<ItemShort>(x.Relic)).Where(x => x != null).ToList();
                        // order relicItems by not vaulted first, then by name
                        relicItems = relicItems.OrderBy(x => x?.Vaulted.GetValueOrDefault()).ThenBy(x => x?.ItemName).Take(21).ToList();
                        if (!relicItems.Any())
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

                            embed.AddField($"{relicItem?.ItemName}{(relicItem?.Vaulted == true ? " (Vaulted)" : "")}", desc.ToString(), true);
                        }

                        await FollowupAsync(embed: embed.Build());
                        return;
                    case DropsourceType.Mission:
                        var missions = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceMission).Select(x => x.GetDropsourceMission()).ToList();
                        if (!missions.Any())
                        {
                            await FollowupAsync($"Unable to find any mission drop sources for {item.ItemName}");
                            return;
                        }
                        var resolvedMissions = missions.Select(x => _svc.ResolveMission(x.Mission)).Where(x => x != null).ToList();
                        missions = missions.OrderByDescending(x => x.Rate).Take(21).ToList();
                        foreach (var mission in missions)
                        {
                            Mission? resolvedMission = resolvedMissions.FirstOrDefault(x => x.Id == mission.Mission);
                            Location? resolvedLocation = _svc.ResolveLocation(mission.Location);
                            if (resolvedMission == null || resolvedLocation == null)
                                continue;

                            var levelRangeString = $"{resolvedLocation.MinLevel}{(resolvedLocation.MinLevel.HasValue && resolvedLocation.MaxLevel.HasValue ? " - " : "")}{resolvedLocation.MaxLevel}";

                            var desc = new StringBuilder();
                            desc.AppendLine($"Location: {resolvedLocation.NodeName} - {resolvedLocation.SystemName} {(!string.IsNullOrWhiteSpace(levelRangeString) ? $"(Lvl. {levelRangeString})" : "")}");
                            if (mission.VarEvent == true)
                                desc.AppendLine($"Event: Yes");
                            if (mission.Rotation.HasValue)
                                desc.AppendLine($"Rotation: {mission.Rotation}");
                            if (mission.Stage != null && mission.Stage.Any())
                                desc.AppendLine($"Stage: {string.Join(", ", mission.Stage)}");
                            desc.AppendLine($"Rarity: {mission.Rarity}");
                            desc.AppendLine($"Rate: {mission.Rate}%");

                            embed.AddField(resolvedMission.Name, desc.ToString(), true);
                        }

                        await FollowupAsync(embed: embed.Build());
                        return;
                    case DropsourceType.Npc:
                        var npcs = fullItemData.Dropsources.Where(x => x.ActualInstance is DropsourceNpc).Select(x => x.GetDropsourceNpc()).ToList();
                        if (!npcs.Any())
                        {
                            await FollowupAsync($"Unable to find any NPC drop sources for {item.ItemName}");
                            return;
                        }
                        npcs = npcs.OrderByDescending(x => x.Rate).Take(21).ToList();
                        foreach (var npc in npcs)
                        {
                            var resolvedNpc = _svc.Resolve<Npc>(npc.Npc);
                            if (resolvedNpc == null)
                                continue;

                            var desc = new StringBuilder();
                            desc.AppendLine($"Rate: {npc.Rate}%");
                            desc.AppendLine($"Rarity: {npc.Rarity}");

                            embed.AddField(resolvedNpc.Name, desc.ToString(), true);
                        }

                        await FollowupAsync(embed: embed.Build());
                        return;
                    default:
                        await FollowupAsync("Invalid drop source type");
                        return;
                }
            }
        }
    }
}
