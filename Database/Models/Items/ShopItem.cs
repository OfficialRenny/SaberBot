using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Models.Items
{
    public class ShopItem
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }

        public int Stock { get; set; }
        public bool IsInfinite { get; set; }

        [NotMapped]
        public bool IsInStock => Stock > 0 || IsInfinite;

        [ForeignKey(nameof(Item))]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
