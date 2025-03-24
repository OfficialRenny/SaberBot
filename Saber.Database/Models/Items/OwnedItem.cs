using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saber.Database.Models.Items;

public class OwnedItem
{
    [Key] public Guid Id { get; set; }

    public int Quantity { get; set; } = 0;

    [ForeignKey(nameof(Item))] public Guid OwnedItemId { get; set; }

    public Item Item { get; set; }

    [ForeignKey(nameof(Inventory))] public Guid InventoryId { get; set; }

    public Inventory Inventory { get; set; }
}