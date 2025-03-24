using System.Text;
using NetCord.Gateway;
using Newtonsoft.Json.Linq;
using Saber.Common.Services.Interfaces;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;

namespace Saber.Common.Services;

public class YoutubeDlService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    private readonly YoutubeDL _youtubeDl;

    public YoutubeDlService(Config config, ILogger logger, HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;

        _youtubeDl = new YoutubeDL(6);
        _youtubeDl.OutputFolder = config.TempDir.FullName;
    }

    public async IAsyncEnumerable<string> GetValidUrlsAsync(string message)
    {
        foreach (var s in Helpers.GetUrls(message))
        {
            var info = await _youtubeDl.RunVideoDataFetch(s);
            if (info is not { Success: true })
                continue;

            yield return s;
        }
    }

    public async Task<FileInfo?> Download(string url, DownloadType? type = null, IProgress<string>? progress = null)
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

    public async Task<FileInfo?> DownloadAsVideo(string url, IProgress<string>? progress = null)
    {
        var res = await _youtubeDl.RunVideoDownload(url, recodeFormat: VideoRecodeFormat.Mp4, output: progress);
        if (res is not { Success: true })
            return null;

        return new FileInfo(res.Data);
    }

    public async Task<FileInfo?> DownloadAsAudio(string url, IProgress<string>? progress = null)
    {
        var res = await _youtubeDl.RunAudioDownload(url, AudioConversionFormat.Mp3, output: progress);
        if (res is not { Success: true })
            return null;

        return new FileInfo(res.Data);
    }

    public async Task<string?> DownloadCaptions(string url, IProgress<string>? progress = null)
    {
        var res = await _youtubeDl.RunVideoDataFetch(url);
        if (res is not { Success: true })
            return null;

        SubtitleData subtitles = null;

        if (res.Data.Subtitles.Any())
        {
            var first = res.Data.Subtitles.FirstOrDefault(x => x.Key == "en" || x.Key == "en-GB" || x.Key == "en-US");
            subtitles = first.Value.FirstOrDefault(x => x.Ext == "json3");
        }
        else if (res.Data.AutomaticCaptions.Any())
        {
            var first = res.Data.AutomaticCaptions.FirstOrDefault(x =>
                x.Key == "en" || x.Key == "en-GB" || x.Key == "en-US");
            subtitles = first.Value.FirstOrDefault(x => x.Ext == "json3");
        }

        if (subtitles == null)
            return null;

        try
        {
            return await DownloadCaptionsFromSubtitles(subtitles, progress);
        }
        catch (Exception e)
        {
            await _logger.LogAsync(LogSeverity.Error, "DownloadCaptions", e.Message, e);
            return null;
        }
    }

    private async Task<string> DownloadCaptionsFromSubtitles(SubtitleData subtitles, IProgress<string>? progress = null)
    {
        var url = subtitles.Url;
        var res = await _httpClient.GetStringAsync(url);
        var data = JObject.Parse(res);

        var segments = data["events"].OrderBy(x => x["tStartMs"]).Select(x => x["segs"]!).Where(x => x != null)
            .ToList();

        var sb = new StringBuilder();
        foreach (var segment in segments)
        foreach (var seg in segment)
            sb.Append(seg["utf8"]!.Value<string>());

        return sb.ToString();
    }
}