using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DelegateDecompiler;

namespace Saber.Database.Models.Items;

public class ShopItem
{
    [Key] public Guid Id { get; set; }

    public int Price { get; set; }

    public int Stock { get; set; }
    public bool IsInfinite { get; set; }

    [NotMapped] [Computed] public bool IsInStock => Stock > 0 || IsInfinite;

    [ForeignKey(nameof(Item))] public Guid ItemId { get; set; }

    public Item Item { get; set; }
}