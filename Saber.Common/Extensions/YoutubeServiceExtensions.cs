using Google.Apis.YouTube.v3;

namespace Saber.Common.Extensions;

public static class YoutubeServiceExtensions
{
    public static async Task<string?> GetSearch(this YouTubeService youtubeService, string search, int maxResults = 3)
    {
        if (string.IsNullOrWhiteSpace(search))
            return null;

        var listRequest = youtubeService.Search.List("snippet");
        listRequest.MaxResults = maxResults;
        listRequest.Q = search;
        listRequest.Type = "video";

        var resp = await listRequest.ExecuteAsync();

        return (resp.Items.Any()
            ? $"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}"
            : null);
    }
}