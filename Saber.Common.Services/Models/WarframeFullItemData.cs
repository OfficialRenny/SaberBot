using WarframeMarket.Model;

namespace Saber.Common.Services.Models;

public class WarframeFullItemData
{
    public WarframeFullItemData(ItemFull item, ICollection<ItemFull> set,
        ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> orders,
        List<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner>? dropsources)
    {
        Item = item;
        ItemsInSet = set;
        Orders = orders;
        Dropsources = dropsources;
    }

    public ItemFull Item { get; set; }
    public ICollection<ItemFull> ItemsInSet { get; set; } = new List<ItemFull>();

    public ICollection<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner> Orders { get; set; } =
        new List<ItemsUrlNameOrdersGet200ResponsePayloadOrdersInner>();

    public ICollection<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner>? Dropsources { get; set; } =
        new List<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner>();

    public DateTime FetchTime { get; set; } = DateTime.UtcNow;
}