using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;
using NetCord.Gateway;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models;
using WarframeMarket.Api;
using WarframeMarket.Model;

namespace Saber.Common.Services;

public class WarframeService
{
    public enum DropsourceType
    {
        Relic,
        Mission,
        Npc
    }

    private const LuceneVersion _lv = LuceneVersion.LUCENE_48;

    private readonly Dictionary<Type, RAMDirectory> _directories = new()
    {
        { typeof(ItemShort), new RAMDirectory() },
        { typeof(Mission), new RAMDirectory() },
        { typeof(Location), new RAMDirectory() },
        { typeof(Npc), new RAMDirectory() }
    };

    private readonly ItemsApi _itemsApi;
    private readonly ILogger _logger;
    private readonly MiscApi _miscApi;

    public WarframeService(ILogger logger)
    {
        _logger = logger;
        _itemsApi = new ItemsApi();
        _miscApi = new MiscApi();
        try
        {
            CacheTask = CacheItems();
        }
        catch (Exception e)
        {
            _logger.LogAsync(LogSeverity.Error, "WarframeService", e.Message, e);
        }
    }

    public List<ItemShort> CachedItems { get; set; } = new();
    public List<Mission> CachedMissions { get; set; } = new();
    public List<Location> CachedLocations { get; set; } = new();
    public List<Npc> CachedNpcs { get; set; } = new();

    public List<WarframeFullItemData> CachedFullItems { get; set; } = new();

    public Task? CacheTask { get; set; }

    public async Task CacheItems()
    {
        await _logger.LogAsync(LogSeverity.Info, "WarframeService", "Caching items...");

        var itemResp = _itemsApi.ItemsGetAsync();
        var missionResp = _miscApi.MissionsGetAsync();
        var locationsResp = _miscApi.LocationsGet();
        var npcResp = _miscApi.NpcGetAsync();

        await Task.WhenAll(itemResp, missionResp, npcResp);

        CachedItems = itemResp.Result.Payload.Items.ToList();
        CachedMissions = missionResp.Result.Payload.Missions.ToList();
        CachedLocations = locationsResp.Payload.Locations.ToList();
        CachedNpcs = npcResp.Result.Payload.Npc.ToList();

        PopulateIndex();

        await _logger.LogAsync(LogSeverity.Info, "WarframeService", "Finished caching items.");
    }

    public async Task<IEnumerable<T>> SearchIndex<T>(string query, int count = 10) where T : class
    {
        if (CacheTask != null && !CacheTask.IsCompleted)
            await CacheTask;

        var type = typeof(T);
        using var analyzer = new StandardAnalyzer(_lv);
        var fieldsToSearch = GetSearchablePropertyNames(type);
        if (fieldsToSearch.Length == 0)
            throw new Exception($"No searchable fields found for `{type.Name}`.");

        var parser = new MultiFieldQueryParser(_lv, fieldsToSearch, analyzer);

        var dictionary = _directories[type];
        if (dictionary == null)
            throw new Exception($"No index found for `{type.Name}`.");

        using var reader = DirectoryReader.Open(dictionary);
        var searcher = new IndexSearcher(reader);
        var q = parser.Parse(query);
        var hits = searcher.Search(q, count).ScoreDocs;

        var results = new List<T>();
        foreach (var hit in hits)
        {
            var doc = searcher.Doc(hit.Doc);
            var result = Resolve<T>(doc.Get("Id"));

            if (result != null) results.Add(result);
        }

        return results;
    }

    public async Task<T?> SearchIndex<T>(string query) where T : class
    {
        return (await SearchIndex<T>(query, 1)).FirstOrDefault();
    }

    public async Task<WarframeFullItemData> GetFullItemDataAsync(string url_name)
    {
        if (CachedItems == null || CachedItems.Count == 0 || CachedItems.All(x => x.UrlName != url_name))
            throw new Exception("Item not found in cache.");

        var cachedData = CachedFullItems.FirstOrDefault(x => x.Item.UrlName == url_name);
        if (cachedData != null)
        {
            if (cachedData.FetchTime.AddMinutes(30) > DateTime.UtcNow) return cachedData;

            CachedFullItems.Remove(cachedData);
        }

        var itemInfoTask = _itemsApi.GetItemInfoAsync(url_name);
        var orderInfoTask = _itemsApi.ItemsUrlNameOrdersGetAsync(url_name);
        var dropSourceInfoTask = _itemsApi.ItemsUrlNameDropsourcesGetAsync(url_name);

        var allTasks = Task.WhenAll(itemInfoTask, orderInfoTask, dropSourceInfoTask);
        await allTasks;
        if (allTasks.IsFaulted)
            throw allTasks.Exception ?? new Exception($"An API call failed for {url_name}.");

        var itemInfo = itemInfoTask.Result.Payload.Item;
        ICollection<ItemFull> itemsInSet = itemInfo.ItemsInSet;
        var item = itemsInSet.First(x => x.UrlName == url_name);
        var orderInfo = orderInfoTask.Result.Payload.Orders;
        var dropSourceInfo = dropSourceInfoTask.Result.Payload.Dropsources;

        var fullItemData = new WarframeFullItemData(item, itemsInSet, orderInfo, dropSourceInfo);
        CachedFullItems.Add(fullItemData);

        return fullItemData;
    }

    public string ResolveAssetUrl(string input)
    {
        return $"https://warframe.market/static/assets/{input}";
    }

    public int GetAveragePrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders,
        ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
    {
        var prices = orders
            .Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online ||
                                                     x.User.Status == UserShort.StatusEnum.Ingame))
            .Select(x => x.Platinum).ToList();
        // get median price
        prices.Sort();
        if (prices.Count % 2 == 0) return (prices[prices.Count / 2] + prices[prices.Count / 2 - 1]) / 2;

        return prices[prices.Count / 2];
    }

    public int GetMinPrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders,
        ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
    {
        var prices = orders
            .Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online ||
                                                     x.User.Status == UserShort.StatusEnum.Ingame))
            .Select(x => x.Platinum).ToList();
        return prices.Min();
    }

    public int GetMaxPrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders,
        ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
    {
        var prices = orders
            .Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online ||
                                                     x.User.Status == UserShort.StatusEnum.Ingame))
            .Select(x => x.Platinum).ToList();
        return prices.Max();
    }

    public ItemShort? ResolveItem(string id)
    {
        return CachedItems.FirstOrDefault(x => x.Id == id);
    }

    public Mission? ResolveMission(string id)
    {
        return CachedMissions.FirstOrDefault(x => x.Id == id);
    }

    public Location? ResolveLocation(string id)
    {
        return CachedLocations.FirstOrDefault(x => x.Id == id);
    }

    public Npc? ResolveNpc(string id)
    {
        return CachedNpcs.FirstOrDefault(x => x.Id == id);
    }

    // generic resolve method
    public T? Resolve<T>(string id) where T : class
    {
        if (typeof(T) == typeof(ItemShort))
            return ResolveItem(id) as T;
        if (typeof(T) == typeof(Mission))
            return ResolveMission(id) as T;
        if (typeof(T) == typeof(Location))
            return ResolveLocation(id) as T;
        if (typeof(T) == typeof(Npc))
            return ResolveNpc(id) as T;
        throw new Exception("Invalid type.");
    }

    public void PopulateIndex()
    {
        var analyzer = new StandardAnalyzer(_lv);
        var indexConfig = new IndexWriterConfig(_lv, analyzer);
        var writer = new IndexWriter(_directories[typeof(ItemShort)], indexConfig);

        foreach (var item in CachedItems)
        {
            var doc = new Document();
            doc.Add(new TextField(nameof(item.Id), item.Id, Field.Store.YES));
            doc.Add(new TextField(nameof(item.UrlName), item.UrlName, Field.Store.YES));
            doc.Add(new TextField(nameof(item.ItemName), item.ItemName, Field.Store.YES));
            doc.Add(new TextField(nameof(item.Thumb), item.Thumb, Field.Store.YES));
            writer.UpdateDocument(new Term(nameof(item.Id), item.Id), doc);
        }

        writer.Flush(false, false);
        writer.Commit();
        writer.Dispose();

        // do the same for other cached items
        analyzer = new StandardAnalyzer(_lv);
        indexConfig = new IndexWriterConfig(_lv, analyzer);
        writer = new IndexWriter(_directories[typeof(Location)], indexConfig);

        foreach (var item in CachedLocations)
        {
            var doc = new Document();
            doc.Add(new TextField(nameof(item.Id), item.Id, Field.Store.YES));
            doc.Add(new TextField(nameof(item.UrlName), item.UrlName, Field.Store.YES));
            //doc.Add(new TextField(nameof(item.Faction), item.Faction.ToString(), Field.Store.YES));
            doc.Add(new TextField(nameof(item.SystemName), item.SystemName, Field.Store.YES));
            doc.Add(new TextField(nameof(item.NodeName), item.NodeName, Field.Store.YES));
            writer.UpdateDocument(new Term(nameof(item.Id), item.Id), doc);
        }

        writer.Flush(false, false);
        writer.Commit();
        writer.Dispose();

        analyzer = new StandardAnalyzer(_lv);
        indexConfig = new IndexWriterConfig(_lv, analyzer);
        writer = new IndexWriter(_directories[typeof(Mission)], indexConfig);

        foreach (var item in CachedMissions)
        {
            var doc = new Document();
            doc.Add(new TextField(nameof(item.Id), item.Id, Field.Store.YES));
            doc.Add(new TextField(nameof(item.UrlName), item.UrlName, Field.Store.YES));
            doc.Add(new TextField(nameof(item.Name), item.Name, Field.Store.YES));
            writer.UpdateDocument(new Term(nameof(item.Id), item.Id), doc);
        }

        writer.Flush(false, false);
        writer.Commit();
        writer.Dispose();

        analyzer = new StandardAnalyzer(_lv);
        indexConfig = new IndexWriterConfig(_lv, analyzer);
        writer = new IndexWriter(_directories[typeof(Npc)], indexConfig);

        foreach (var item in CachedNpcs)
        {
            var doc = new Document();
            doc.Add(new TextField(nameof(item.Id), item.Id, Field.Store.YES));
            doc.Add(new TextField(nameof(item.UrlName), item.UrlName, Field.Store.YES));
            doc.Add(new TextField(nameof(item.Name), item.Name, Field.Store.YES));
            writer.UpdateDocument(new Term(nameof(item.Id), item.Id), doc);
        }

        writer.Flush(false, false);
        writer.Commit();
        writer.Dispose();
    }

    private static string[] GetSearchablePropertyNames(Type type)
    {
        return type switch
        {
            { } t when t == typeof(ItemShort) => [nameof(ItemShort.ItemName), nameof(ItemShort.UrlName)],
            { } t when t == typeof(Mission) => [nameof(Mission.Name), nameof(Mission.UrlName)],
            { } t when t == typeof(Location) =>
            [
                nameof(Location.NodeName), nameof(Location.SystemName), nameof(Location.UrlName)
            ],
            { } t when t == typeof(Npc) => [nameof(Npc.Name), nameof(Npc.UrlName)],
            _ => throw new Exception("Invalid type.")
        };
    }
}