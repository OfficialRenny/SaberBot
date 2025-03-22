using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services.Models.MusicPlayer;
using Discord;
using Google.Apis.YouTube.v3;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services
{
    public class MusicPlayerService
    {
        private readonly YouTubeService _youTubeService;
        private readonly AudioService _audioService;
        private readonly YoutubeDlService _youtubeDlService;
        private readonly ILogger _logger;

        private readonly ConcurrentDictionary<ulong, Queue> ActiveQueues = new ConcurrentDictionary<ulong, Queue>();

        public MusicPlayerService(YouTubeService youTubeService, AudioService audioService, YoutubeDlService youtubeDlService, ILogger logger)
        {
            _youTubeService = youTubeService;
            _audioService = audioService;
            _youtubeDlService = youtubeDlService;
            _logger = logger;
        }


    }
}
