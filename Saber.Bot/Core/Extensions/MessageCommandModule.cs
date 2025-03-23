using NetCord.Services.Commands;
using Saber.Common;
using Saber.Common.Services.Interfaces;

namespace Saber.Bot.Core.Extensions;

public partial class MessageCommandModule<T> : CommandModule<T> where T : CommandContext
{
    public required Config Config { get; set; }
    public required ILogger Logger { get; set; }
}