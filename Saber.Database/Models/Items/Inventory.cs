using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Saber.Database.Models.Profile;

namespace Saber.Database.Models.Items;

public class Inventory
{
    [Key] public Guid Id { get; set; }

    public int Currency { get; set; } = 0;
    public ICollection<OwnedItem> OwnedItems { get; set; } = new List<OwnedItem>();

    [InverseProperty("Inventory")] public virtual UserProfile UserProfile { get; set; }
}