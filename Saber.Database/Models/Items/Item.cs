using System.ComponentModel.DataAnnotations;

namespace Saber.Database.Models.Items;

public abstract class Item
{
    [Key] public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
}

public class DiscordAward : Item
{
}