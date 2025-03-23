using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services.Models.MusicPlayer;
using Google.Apis.YouTube.v3;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services
{
    public class MusicPlayerService(
        YouTubeService youTubeService,
        AudioService audioService,
        YoutubeDlService youtubeDlService,
        ILogger logger)
    {
        private readonly YouTubeService _youTubeService = youTubeService;
        private readonly AudioService _audioService = audioService;
        private readonly YoutubeDlService _youtubeDlService = youtubeDlService;
        private readonly ILogger _logger = logger;

        private readonly ConcurrentDictionary<ulong, Queue> ActiveQueues = new ConcurrentDictionary<ulong, Queue>();
    }
}
