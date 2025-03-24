using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Saber.Database.Models;

[Index(nameof(GuildId), IsUnique = true)]
public class CommandPrefix
{
    [Key] public int Id { get; set; }

    public ulong GuildId { get; set; }

    public string Prefix { get; set; } = ";";
}