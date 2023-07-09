using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDLSharp;

namespace Saber.Common.Services
{
    public class YoutubeDlService
    {
        private readonly Config _config;
        private readonly YoutubeDL _youtubeDl;

        public YoutubeDlService(Config config)
        {
            _config = config;

            _youtubeDl = new YoutubeDL(6);
            _youtubeDl.OutputFolder = _config.TempDir.FullName;
        }

        public async IAsyncEnumerable<string> GetValidUrlsAsync(string message)
        {
            foreach (var s in Helpers.GetUrls(message))
            {
                var info = await _youtubeDl.RunVideoDataFetch(s);
                if (info == null || !info.Success)
                    continue;

                yield return s;
            }
        }

        public async Task<FileInfo?> Download(string url, DownloadType? type = null)
        {
            FileInfo? fileInfo;

            switch (type)
            {
                case DownloadType.Audio:
                    fileInfo = await DownloadAsAudio(url);
                    break;
                case DownloadType.Video:
                default:
                    fileInfo = await DownloadAsVideo(url);
                    break;
            }

            return fileInfo;
        }

        public async Task<FileInfo?> DownloadAsVideo(string url)
        {
            var res = await _youtubeDl.RunVideoDownload(url, recodeFormat: YoutubeDLSharp.Options.VideoRecodeFormat.Mp4);
            if (res == null || !res.Success)
                return null;

            return new FileInfo(res.Data);
        }

        public async Task<FileInfo?> DownloadAsAudio(string url)
        {
            var res = await _youtubeDl.RunAudioDownload(url, YoutubeDLSharp.Options.AudioConversionFormat.Mp3);
            if (res == null || !res.Success)
                return null;

            return new FileInfo(res.Data);
        }

    }
}
