using System.Collections.Concurrent;
using Google.Apis.YouTube.v3;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models.MusicPlayer;

namespace Saber.Common.Services;

public class MusicPlayerService(
    YouTubeService youTubeService,
    AudioService audioService,
    YoutubeDlService youtubeDlService,
    ILogger logger)
{
    private readonly AudioService _audioService = audioService;
    private readonly ILogger _logger = logger;
    private readonly YoutubeDlService _youtubeDlService = youtubeDlService;
    private readonly YouTubeService _youTubeService = youTubeService;

    private readonly ConcurrentDictionary<ulong, Queue> ActiveQueues = new();
}