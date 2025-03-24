using System.ComponentModel.DataAnnotations;

namespace Saber.Database.Models.Guilds;

public class Guild
{
    [Key] public Guid Id { get; set; }

    public ulong GuildId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Prefix { get; set; } = ";";
}