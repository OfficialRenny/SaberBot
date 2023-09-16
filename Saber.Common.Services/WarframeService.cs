using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Saber.Common.Services.Models;
using WarframeMarket;
using WarframeMarket.Model;

namespace Saber.Common.Services
{
    public class WarframeService
    {
        private const Lucene.Net.Util.LuceneVersion _lv = Lucene.Net.Util.LuceneVersion.LUCENE_48;
        private readonly WarframeMarket.Api.ItemsApi _itemsApi;
        private readonly WarframeMarket.Api.MiscApi _miscApi;

        private readonly Dictionary<Type, RAMDirectory> _directories = new ()
        {
            { typeof(ItemShort), new RAMDirectory() },
            { typeof(Mission), new RAMDirectory() },
            { typeof(Location), new RAMDirectory() },
            { typeof(Npc), new RAMDirectory() },
        };

        public List<ItemShort> CachedItems { get; set; } = new List<ItemShort>();
        public List<Mission> CachedMissions { get; set; } = new List<Mission>();
        public List<Location> CachedLocations { get; set; } = new List<Location>();
        public List<Npc> CachedNpcs { get; set; } = new List<Npc>();

        public List<WarframeFullItemData> CachedFullItems { get; set; } = new List<WarframeFullItemData>();

        public Task? CacheTask { get; set; } = null;

        public WarframeService()
        {
            _itemsApi = new WarframeMarket.Api.ItemsApi();
            _miscApi = new WarframeMarket.Api.MiscApi();
            CacheTask = CacheItems();
        }

        public async Task CacheItems()
        {
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
        }

        public IEnumerable<T> SearchIndex<T>(string query, int count = 10) where T : class
        {
            var type = typeof(T);
            using var analyzer = new StandardAnalyzer(_lv);
            string[] fieldsToSearch = GetSearchablePropertyNames(type);
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

                if (result != null)
                {
                    results.Add(result);
                }
            }
            return results;
        }

        public T? SearchIndex<T>(string query) where T : class
            => SearchIndex<T>(query, 1).FirstOrDefault();

        public async Task<WarframeFullItemData> GetFullItemDataAsync(string url_name)
        {
            if (CachedItems == null || !CachedItems.Any() || !CachedItems.Any(x => x.UrlName == url_name))
                throw new Exception("Item not found in cache.");

            var cachedData = CachedFullItems.FirstOrDefault(x => x.Item.UrlName == url_name);
            if (cachedData != null)
            {
                if (cachedData.FetchTime.AddMinutes(30) > DateTime.UtcNow)
                {
                    return cachedData;
                }
                else
                {
                    CachedFullItems.Remove(cachedData);
                }
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
            => $"https://warframe.market/static/assets/{input}";

        public int GetAveragePrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders, ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
        {
            var prices = orders.Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online || x.User.Status == UserShort.StatusEnum.Ingame)).Select(x => x.Platinum).ToList();
            // get median price
            prices.Sort();
            if (prices.Count % 2 == 0)
            {
                return (int)((prices[prices.Count / 2] + prices[prices.Count / 2 - 1]) / 2);
            }
            else
            {
                return (int)prices[prices.Count / 2];
            }
        }

        public int GetMinPrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders, ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
        {
            var prices = orders.Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online || x.User.Status == UserShort.StatusEnum.Ingame)).Select(x => x.Platinum).ToList();
            return (int)prices.Min();
        }

        public int GetMaxPrice(ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders, ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner.OrderTypeEnum orderType)
        {
            var prices = orders.Where(x => x.OrderType == orderType && (x.User.Status == UserShort.StatusEnum.Online || x.User.Status == UserShort.StatusEnum.Ingame)).Select(x => x.Platinum).ToList();
            return (int)prices.Max();
        }

        public ItemShort? ResolveItem(string id) => CachedItems.FirstOrDefault(x => x.Id == id);
        public Mission? ResolveMission(string id) => CachedMissions.FirstOrDefault(x => x.Id == id);
        public Location? ResolveLocation(string id) => CachedLocations.FirstOrDefault(x => x.Id == id);
        public Npc? ResolveNpc(string id) => CachedNpcs.FirstOrDefault(x => x.Id == id);

        // generic resolve method
        public T? Resolve<T>(string id) where T : class
        {
            if (typeof(T) == typeof(ItemShort))
                return ResolveItem(id) as T;
            else if (typeof(T) == typeof(Mission))
                return ResolveMission(id) as T;
            else if (typeof(T) == typeof(Location))
                return ResolveLocation(id) as T;
            else if (typeof(T) == typeof(Npc))
                return ResolveNpc(id) as T;
            else
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

            writer.Flush(triggerMerge: false, applyAllDeletes: false);
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

            writer.Flush(triggerMerge: false, applyAllDeletes: false);
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

            writer.Flush(triggerMerge: false, applyAllDeletes: false);
            writer.Commit();
            writer.Dispose();

            analyzer = new StandardAnalyzer(_lv );
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

            writer.Flush(triggerMerge: false, applyAllDeletes: false);
            writer.Commit();
            writer.Dispose();
        }

        private static string[] GetSearchablePropertyNames(Type type)
        {
            if (type == typeof(ItemShort))
            {
                return new string[] { nameof(ItemShort.ItemName), nameof(ItemShort.UrlName) };
            }
            else if (type == typeof(Mission))
            {
                return new string[] { nameof(Mission.Name), nameof(Mission.UrlName) };
            }
            else if (type == typeof(Location))
            {
                return new string[] { nameof(Location.NodeName), nameof(Location.SystemName), nameof(Location.UrlName) };
            }
            else if (type == typeof(Npc))
            {
                return new string[] { nameof(Npc.Name), nameof(Npc.UrlName) };
            }
            else
            {
                throw new Exception("Invalid type.");
            }
        }

        public enum DropsourceType
        {
            Relic,
            Mission,
            Npc
        }
    }
}
