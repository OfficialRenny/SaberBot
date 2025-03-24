using NetCord.Rest;

namespace Saber.Bot.Core.Extensions;

public static class EmbedPropertiesExtensions
{
    public static void AddField(this EmbedProperties embed, string name, string value, bool inline = false)
    {
        embed.Fields ??= new List<EmbedFieldProperties>();
        embed.AddFields(new EmbedFieldProperties
        {
            Name = name,
            Value = value,
            Inline = inline
        });
    }

    public static void AddField(this EmbedProperties embed, EmbedFieldProperties? field)
    {
        if (field is null)
            return;

        embed.Fields ??= new List<EmbedFieldProperties>();
        embed.AddFields(field);
    }
}