using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; } = 0;

        [ForeignKey(nameof(Inventory))]
        public int InventoryId { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual ShopItem Item { get; set; }
    }
}
