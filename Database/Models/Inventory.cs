using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(UserProfile))]
        public int UserProfileId { get; set; }

        public int Currency { get; set; } = 0;

        public ICollection<InventoryItem> Items { get; set; } = new HashSet<InventoryItem>();

        public virtual UserProfile UserProfile { get; set; }
    }
}
