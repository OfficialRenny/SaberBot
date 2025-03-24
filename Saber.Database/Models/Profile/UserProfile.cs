using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Saber.Database.Models.Items;

namespace Saber.Database.Models.Profile;

[Index(nameof(DiscordId), IsUnique = true)]
public class UserProfile
{
    [Key] public Guid Id { get; set; }

    public ulong DiscordId { get; set; }
    public bool IsAdmin { get; set; }

    public string LastKnownDisplayName { get; set; } = string.Empty;
    public int TotalMessagesSent { get; set; }
    public int TotalCommandsExecuted { get; set; }

    [DefaultValue(AccessRoles.DEFAULT)] public AccessRoles AccessRoles { get; set; } = AccessRoles.DEFAULT;

    public int Xp { get; set; }

    [NotMapped] public int Level => GetLevel(Xp);

    [ForeignKey(nameof(Inventory))] public Guid InventoryId { get; set; }

    public virtual Inventory Inventory { get; set; } = new();

    public void IncrementMessagesSent()
    {
        TotalMessagesSent++;
        Xp += Level + 1;
    }

    public void IncrementCommandsExecuted()
    {
        TotalCommandsExecuted++;
        Xp += Level + 5;
    }

    public static int GetLevel(int xp)
    {
        return (int)Math.Floor(Math.Max(1, CalculateLevel(xp)));
    }

    public static double CalculateLevel(int xp)
    {
        var t1 = 1 / 2;
        var t2 = Math.Sqrt(8 * xp + 5) / (2 * Math.Sqrt(5));

        return t1 + t2;
    }
}

[Flags]
public enum AccessRoles : ulong
{
    OpenAiTextGen = 1,
    OpenAiImageGen = 2,
    YoutubeDl = 4,

    DEFAULT = OpenAiTextGen | YoutubeDl
}